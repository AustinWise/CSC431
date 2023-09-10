namespace CSC431.Steps
{
    public interface IOutStep : IStep
    {
        object OutputAsObject { get; set; }
    }

    public interface IOutStep<T> : IOutStep
    {
        T Output { get; set; }
        void FollowWith(InStep<T> next);
        IOutStep<Out> FollowWith<Out>(InOutStep<T, Out> next);
    }
}
