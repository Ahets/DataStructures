using DataStructures.Core.Contracts;
using System;

namespace DataStructures.Core
{
    public class Queue<T> : IQueue<T>
    {

        private class QueueItem
        {
            public T Value { get; }
            public QueueItem Next { get; set; }

            public QueueItem(T value)
            {
                Value = value;
            }
        }

        private QueueItem tail;
        private QueueItem head;

        public void Push(T item)
        {
            var newItem = new QueueItem(item);
            if (tail != null)
                tail.Next = newItem;
            tail = newItem;
            if (head == null)
                head = newItem;
        }

        public T Pop()
        {
            if (Empty)
                throw new InvalidOperationException("Queue is empty");
            var oldItem = head;
            head = oldItem.Next;
            return oldItem.Value;
        }

        public T Top
        {
            get
            {
                if (Empty)
                    throw new InvalidOperationException("Queue is empty");
                return head.Value;
            }
        }

        public bool Empty
        {
            get
            {
                return head == null;
            }
        }
    }
}
