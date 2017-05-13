using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core
{
    public class List<T> : Contracts.IList<T>
    {
        private class ListItem
        {
            private T Value { get; }
            private ListItem Previous { get; }
            private ListItem Next { get; }

            private ListItem(ListItem previous, ListItem next)
            {
                Previous = previous;
                Next = next;
            }
        }

        private ListItem
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PushHead(T item)
        {
            throw new System.NotImplementedException();
        }

        public void PushTail(T item)
        {
            throw new System.NotImplementedException();
        }

        public T PopHead()
        {
            throw new System.NotImplementedException();
        }

        public T PopTail()
        {
            throw new System.NotImplementedException();
        }

        public T Head { get; }
        public T Tail { get; }
        public bool Empty { get; }
    }
}
