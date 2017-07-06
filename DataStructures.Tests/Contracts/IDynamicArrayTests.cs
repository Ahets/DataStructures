using DataStructures.Core.Contracts;
using NUnit.Framework;

namespace DataStructures.Tests.Contracts
{
    public class IDynamicArrayTests<T> where T: IDynamicArray<int>, new()
    {
        [Test]
        public void AddElement()
        {
            var array = new T();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(6);
            array.Add(7);
            array.Add(8);
            array.Add(9);
            array.Add(0);

            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(3, array[2]);
            Assert.AreEqual(4, array[3]);
            Assert.AreEqual(5, array[4]);
            Assert.AreEqual(6, array[5]);
            Assert.AreEqual(7, array[6]);
            Assert.AreEqual(8, array[7]);
            Assert.AreEqual(9, array[8]);
            Assert.AreEqual(0, array[9]);
            Assert.AreEqual(10, array.Count);
        }

        [Test]
        public void ContainsElements()
        {
            var array = new T {1, 2, 3, 4, 5};

            Assert.IsTrue(array.Contains(2));
            Assert.IsTrue(array.Contains(4));
            Assert.IsFalse(array.Contains(8));
            Assert.IsFalse(array.Contains(10));
        }

        [Test]
        public void RemoveElement()
        {
            var array = new T {1, 2, 3, 4, 5};

            Assert.IsTrue(array.Remove(1));
            Assert.IsTrue(array.Remove(3));
            Assert.IsFalse(array.Remove(3));
            Assert.IsFalse(array.Remove(6));
            Assert.AreEqual(3, array.Count);
        }

        [Test]
        public void RemoveDuplicatedElement()
        {
            var array = new T {1, 2, 3, 4, 5, 3};

            Assert.IsTrue(array.Remove(3));
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(4, array[2]);
            Assert.AreEqual(3, array[4]);
            Assert.AreEqual(5, array.Count);

            Assert.IsTrue(array.Remove(3));
            Assert.AreEqual(5, array[3]);
            Assert.AreEqual(4, array.Count);
        }

        [Test]
        public void ClearArray()
        {
            var array = new T {1, 2, 3, 4, 5};

            array.Clear();
            Assert.AreEqual(0, array.Count);
        }

        [Test]
        public void IndexOfElement()
        {
            var array = new T {1, 2, 3, 4, 5};

            Assert.AreEqual(0, array.IndexOf(1));
            Assert.AreEqual(1, array.IndexOf(2));
            Assert.AreEqual(2, array.IndexOf(3));
            Assert.AreEqual(3, array.IndexOf(4));
            Assert.AreEqual(4, array.IndexOf(5));
            Assert.AreEqual(-1, array.IndexOf(6));
        }

        [Test]
        public void InsertElement()
        {
            var array = new T { 1, 2, 3, 4, 5 };

            array.Insert(3, 6);

            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(3, array[2]);
            Assert.AreEqual(6, array[3]);
            Assert.AreEqual(4, array[4]);
            Assert.AreEqual(5, array[5]);
        }

        [Test]
        public void RemoveAtIndex()
        {
            var array = new T { 1, 2, 3, 4, 5 };

            array.RemoveAt(2);

            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(4, array[2]);
            Assert.AreEqual(5, array[3]);
        }
    }
}