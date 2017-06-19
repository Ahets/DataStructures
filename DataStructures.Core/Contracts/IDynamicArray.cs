using System.Collections.Generic;

namespace DataStructures.Core.Contracts
{
    public interface IDynamicArray<T> : IEnumerable<T>
    {
        void Add(T item);
        bool Remove(T item);
        bool Contains(T item);
        void Clear();
        T this[int index] { get; set; }
        int Count { get; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
}