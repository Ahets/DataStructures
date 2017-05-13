using System.Collections.Generic;

namespace DataStructures.Core.Contracts
{
    public interface IList<T> : IEnumerable<T>
    {
        void PushHead(T item);
        void PushTail(T item);
        T PopHead();
        T PopTail();
        T Head { get; }
        T Tail { get; }
        bool Empty { get; }
    }
}
