﻿using System;

namespace CSC431.Steps
{
    public class OutStep<T> : Step, IOutStep<T>
    {
        public OutStep(Func<T> fun)
        {
            this.fun = fun;
            SetName(fun.Method);
        }

        private Func<T> fun;

        public T Output { get; set; }

        object IOutStep.OutputAsObject
        {
            get => Output;
            set => Output = (T)value;
        }

        protected override void Process()
        {
            this.Output = fun();
        }

        public void FollowWith(InStep<T> next)
        {
            AddNext(next);
        }

        public IOutStep<Out> FollowWith<Out>(InOutStep<T, Out> next)
        {
            AddNext(next);
            return next;
        }

        public override void Dispose()
        {
            base.Dispose();
            this.Output = default(T);
            this.fun = null;
        }
    }
}
