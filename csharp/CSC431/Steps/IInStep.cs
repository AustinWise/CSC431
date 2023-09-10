namespace CSC431.Steps
{
    public interface IInStep : IStep
    {
        object InputAsObject { get; set; }
    }

    public interface IInStep<T> : IInStep
    {
        T Input { get; set; }
    }
}
