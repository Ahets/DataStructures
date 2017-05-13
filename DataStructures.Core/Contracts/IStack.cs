namespace DataStructures.Core.Contracts
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Top { get; }
        bool Empty { get; }
    }
}
