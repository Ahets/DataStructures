using DataStructures.Core.Contracts;
using System;

namespace DataStructures.Core
{
    public class Stack<T> : IStack<T>
    {
        private class StackItem
        {
            public T Value { get; }
            public StackItem Next { get; }

            public StackItem(T value, StackItem next)
            {
                Value = value;
                Next = next;
            }
        }

        private StackItem current;

        public void Push(T item)
        {
            var newItem = new StackItem(item, current);
            current = newItem;
        }

        public T Pop()
        {
            if (Empty)
                throw new InvalidOperationException("Stack is empty");
            var oldItem = current;
            current = oldItem.Next;
            return oldItem.Value;
        }

        public T Top
        {
            get
            {
                if (Empty)
                    throw new InvalidOperationException("Stack is empty");
                return current.Value;
            }
        }

        public bool Empty
        {
            get
            {
                return current == null;
            }
        }
    }
}
