using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Core
{
    public class List<T> : Contracts.IList<T>
    {
        private class ListItem
        {
            public T Value { get; }
            public ListItem Previous { get; set; }
            public ListItem Next { get; set; }

            public ListItem(ListItem previous, ListItem next, T value)
            {
                Previous = previous;
                Next = next;
                Value = value;
            }
        }

        private ListItem head;
        private ListItem tail;

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PushHead(T item)
        {
            var newHeadItem = new ListItem(null, head, item);
            if (head != null)   
                head.Previous = newHeadItem;
            head = newHeadItem;
            if (tail == null)
                tail = newHeadItem;
        }

        public void PushTail(T item)
        {
            var newTailItem = new ListItem(tail, null, item);
            if (tail != null)
                tail.Next = newTailItem;
            tail = newTailItem;
            if (head == null)
                head = newTailItem;
        }

        public T PopHead()
        {
            if (Empty)
                throw new InvalidOperationException("List is empty");
            var oldHeadItem = head;
            head = oldHeadItem.Next;
            if (head != null)
                head.Previous = null;
            else
                tail = null;
            return oldHeadItem.Value;
        }

        public T PopTail()
        {
            if (Empty)
                throw new InvalidOperationException("List is empty");
            var oldTailItem = tail;
            tail = oldTailItem.Previous;
            if (tail != null)
                tail.Next = null;
            else
                head = null;
            return oldTailItem.Value;
        }

        public T Head
        {
            get
            {
                if (Empty)
                    throw new InvalidOperationException("List is empty");
                return head.Value;
            }
        }

        public T Tail
        {
            get
            {
                if (Empty)
                    throw new InvalidOperationException("List is empty");
                return tail.Value;
            }
        }

        public bool Empty
        {
            get
            {
                return tail == null;
            }
        }
    }
}
