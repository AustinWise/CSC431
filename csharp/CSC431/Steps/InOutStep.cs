using System;

namespace CSC431.Steps
{
    public class InOutStep<In, Out> : Step, IInStep<In>, IOutStep<Out>
    {
        public InOutStep(Func<In, Out> fun)
        {
            this.fun = fun;
            SetName(fun.Method);
        }

        private Func<In, Out> fun;

        public In Input { get; set; }
        public Out Output { get; set; }

        object IInStep.InputAsObject
        {
            get => Input;
            set => Input = (In)value;
        }

        object IOutStep.OutputAsObject
        {
            get => Output;
            set => Output = (Out)value;
        }

        protected override void Process()
        {
            this.Output = fun(Input);
        }

        public void FollowWith(InStep<Out> next)
        {
            this.AddNext(next);
        }

        public IOutStep<FollowOut> FollowWith<FollowOut>(InOutStep<Out, FollowOut> next)
        {
            this.AddNext(next);
            return next;
        }

        public override void Dispose()
        {
            base.Dispose();
            this.Input = default(In);
            this.Output = default(Out);
            this.fun = null;
        }
    }
}
