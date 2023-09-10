using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSC431.Steps
{
    public abstract class Step : IStep, IDisposable
    {
        protected abstract void Process();

        public virtual void Dispose()
        {
            this.nexts = null;
            this.parent = null;
        }

        private Step parent;
        private List<IInStep> nexts = new List<IInStep>();
        public string Name { get; private set; }

        protected void SetName(MethodInfo meth)
        {
            string methName = meth.Name;

            bool genedMeth = meth.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).Length != 0;
            bool genedClass = meth.DeclaringType.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).Length != 0;

            if (genedMeth || genedClass)
            {
                methName = methName.Substring(methName.IndexOf('<') + 1);
                methName = methName.Substring(0, methName.IndexOf('>'));
            }

            string className = meth.DeclaringType.Name;
            if (genedClass)
            {
                className = meth.DeclaringType.DeclaringType.Name;
            }

            if (className.EndsWith("Steps"))
                className = className.Substring(0, className.IndexOf("Steps"));

            Name = className + "." + methName;
        }

        protected void AddNext(IInStep next)
        {
            if (next == null)
                throw new ArgumentNullException();

            var s = next.AsStep();
            s.parent = this;
            nexts.Add(next);
        }

        public Step AsStep()
        {
            return this;
        }

        public static void DoAll(Step s)
        {
            while (s.parent != null)
            {
                s = s.parent;
            }

            Queue<Step> toDos = new Queue<Step>();
            toDos.Enqueue(s);

            while (toDos.Count != 0)
            {
                s = toDos.Dequeue();
                s.Process();

                if (s is IOutStep outStep)
                {
                    // FollowWith should have made sure the types are compatible.
                    object res = outStep.OutputAsObject;
                    foreach (var n in s.nexts)
                    {
                        n.InputAsObject = res;
                        toDos.Enqueue(n.AsStep());
                    }
                }
                else
                {
                    if (s.nexts.Count != 0)
                        throw new NotSupportedException("non-output steps should not be followed");
                }

                s.Dispose();
            }
        }

        /// <summary>
        /// Executes steps concurrently.  Not compatable with code that uses TaskLocal (the compiler use TaskLocal).
        /// </summary>
        /// <param name="aStep"></param>
        public static void DoAllThreaded(Step aStep)
        {
            while (aStep.parent != null)
            {
                aStep = aStep.parent;
            }

            Queue<Step> toDos = new Queue<Step>();
            toDos.Enqueue(aStep);

            Dictionary<Step, Task> map = new Dictionary<Step, Task>();
            List<Task> leafTasks = new List<Task>();
            Task top = null;

            while (toDos.Count != 0)
            {
                Step s = toDos.Dequeue();

                Task t;
                if (s.parent == null)
                    t = top = new Task(() => { Console.WriteLine("top"); s.Process(); });
                else
                    t = map[s.parent].ContinueWith(_ => s.Process());

                if (s is IOutStep outStep)
                {
                    t = t.ContinueWith(_ =>
                    {
                        // FollowWith should have made sure the types are compatible.
                        object res = outStep.OutputAsObject;
                        foreach (var n in s.nexts)
                        {
                            n.InputAsObject = res;
                        }
                    });

                    foreach (var n in s.nexts)
                    {
                        toDos.Enqueue(n.AsStep());
                    }
                }
                else
                {
                    if (s.nexts.Count != 0)
                        throw new NotSupportedException("non-output steps should not be followed");
                    leafTasks.Add(t);
                }

                map[s] = t;
            }

            top.Start();
            Task.WaitAll(leafTasks.ToArray());
        }

        public static string MakeGraph(Step s)
        {
            while (s.parent != null)
            {
                s = s.parent;
            }

            Queue<Step> toDos = new Queue<Step>();
            toDos.Enqueue(s);

            var allSteps = new List<Step>();

            while (toDos.Count != 0)
            {
                s = toDos.Dequeue();
                allSteps.Add(s);

                if (s is IOutStep)
                {
                    foreach (var n in s.nexts)
                    {
                        toDos.Enqueue(n.AsStep());
                    }
                }
                else
                {
                    if (s.nexts.Count != 0)
                        throw new NotSupportedException("non-output steps should not be followed");
                }
            }

            var sb = new StringBuilder();

            sb.AppendLine("digraph {");
            for (int i = 0; i < allSteps.Count; i++)
            {
                sb.AppendFormat("\tn{0} [label=\"{1}\"];", i, allSteps[i].Name);
                sb.AppendLine();
            }
            sb.AppendLine();
            for (int i = 0; i < allSteps.Count; i++)
            {
                foreach (var next in allSteps[i].nexts)
                {
                    sb.AppendFormat("\tn{0} -> n{1}", i, allSteps.IndexOf(next.AsStep()));
                    sb.AppendLine();
                }
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
