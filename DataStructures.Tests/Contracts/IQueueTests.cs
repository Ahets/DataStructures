using System;
using DataStructures.Core.Contracts;
using NUnit.Framework;

namespace DataStructures.Tests.Contracts
{
    public class IQueueTests<T> where T: IQueue<int>, new()
    {
        [Test]
        public void Empty()
        {
            var stack = new T();

            Assert.IsTrue(stack.Empty);
            Assert.Throws(Is.InstanceOf<Exception>(), () => { var _ = stack.Top; });
            Assert.Throws(Is.InstanceOf<Exception>(), () => stack.Pop());
        }

        [Test]
        public void Push()
        {
            var stack = new T();

            stack.Push(1);

            Assert.IsFalse(stack.Empty);
            Assert.AreEqual(1, stack.Top);

            stack.Push(2);

            Assert.AreEqual(1, stack.Top);
        }

        [Test]
        public void Pop()
        {
            var list = new T();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);

            Assert.AreEqual(1, list.Pop());
            Assert.AreEqual(2, list.Pop());
            Assert.AreEqual(3, list.Pop());
            Assert.AreEqual(4, list.Pop());
            Assert.AreEqual(5, list.Pop());
            Assert.IsTrue(list.Empty);
        }
    }
}