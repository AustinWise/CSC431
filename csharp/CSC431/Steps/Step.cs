using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC431.Steps
{
    public abstract class Step : IStep
    {
        protected abstract void Process();

        private Step parent;
        private List<Step> nexts = new List<Step>();

        protected void AddNext(Step next)
        {
            if (next == null)
                throw new ArgumentNullException();
            next.parent = this;
            nexts.Add(next);
        }

        public Step AsStep()
        {
            return this;
        }

        private static bool isOut(System.Type t)
        {
            foreach (var i in t.GetInterfaces())
            {
                if (!i.IsGenericType)
                    continue;
                if (typeof(IOutStep<>).IsAssignableFrom(i.GetGenericTypeDefinition()))
                    return true;
            }
            return false;
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

                if (isOut(s.GetType()))
                {
                    //it ~should~ be ok to use dynamic like this as the 
                    //FollowWith functions should have ensured that types lined up
                    dynamic ds = s;
                    dynamic res = ds.Output;
                    foreach (var n in s.nexts)
                    {
                        dynamic dn = n;
                        dn.Input = res;
                        toDos.Enqueue(n);
                    }
                }
                else
                {
                    if (s.nexts.Count != 0)
                        throw new NotSupportedException("non-output steps should not be followed");
                }
            }
        }

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

                if (isOut(s.GetType()))
                {
                    t = t.ContinueWith(_ =>
                    {
                        //it ~should~ be ok to use dynamic like this as the 
                        //FollowWith functions should have ensured that types lined up
                        dynamic ds = s;
                        dynamic res = ds.Output;
                        foreach (var n in s.nexts)
                        {
                            dynamic dn = n;
                            dn.Input = res;
                        }
                    });

                    foreach (var n in s.nexts)
                    {
                        toDos.Enqueue(n);
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
    }
}
