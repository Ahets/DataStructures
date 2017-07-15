using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.Core.Contracts;

namespace DataStructures.Core
{
    public class DynamicArray<T> : IDynamicArray<T>
    {
        private int _capacity;
        private int _count;
        private T[] _arr;

        public DynamicArray()
        {
           InitEmpty();
        }

        public T this[int index]
        {
            get { return _arr[index]; }

            set { _arr[index] = value; }
        }

        public int Count
        {
            get { return _count; }
        }

        public void Add(T item)
        {
            ValidateCapacity();
            _arr[_count] = item;
            _count++;
        }

        public void Clear()
        {
            InitEmpty();
        }

        public bool Contains(T item)
        {
            for (int index = 0; index < _count; index++)
            {
                if (item.Equals(_arr[index]))
                    return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < _count; index++)
            {
                yield return _arr[index];
            }
        }

        public int IndexOf(T item)
        {
            for (int index = 0; index < _count; index++)
            {
                if (item.Equals(_arr[index]))
                    return index;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);
            ValidateCapacity();
            for (int it = _count - 1; it >= index; it--)
            {
                _arr[it + 1] = _arr[it];
            }
            _arr[index] = item;
            _count++;
        }

        public bool Remove(T item)
        {
            for (int index = 0; index < _count; index++)
            {
                if (item.Equals(_arr[index]))
                {
                    for (int it = index; it < _count; it++)
                    {
                        _arr[it] = _arr[it + 1];
                    }
                    _count--;
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);
            for (int it = index; it < _count; it++)
            {
                _arr[it] = _arr[it + 1];
            }
            _count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void InitEmpty()
        {
            _capacity = 2;
            _count = 0;
            _arr = new T[_capacity];
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > _count)
                throw new ArgumentOutOfRangeException(nameof(index));
        }

        private void ValidateCapacity()
        {
            if (_count == _capacity)
            {
                T[] oldArray = _arr;
                _capacity = 2 * _capacity;
                _arr = new T[_capacity];
                for (int index = 0; index < oldArray.Length; index++)
                {
                    _arr[index] = oldArray[index];
                }
            }
        }
    }
}
