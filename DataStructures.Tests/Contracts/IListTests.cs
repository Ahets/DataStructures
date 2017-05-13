using System;
using DataStructures.Core.Contracts;
using NUnit.Framework;

namespace DataStructures.Tests.Contracts
{
    public class IListTests<T> where T : IList<int>, new()
    {
        [Test]
        public void AddElementsToBack()
        {
            var list = new T();

            list.PushTail(1);

            Assert.IsFalse(list.Empty);
            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(1, list.Tail);

            list.PushTail(2);

            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(2, list.Tail);
        }

        [Test]
        public void AddElementsToFront()
        {
            var list = new T();

            list.PushHead(1);

            Assert.IsFalse(list.Empty);
            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(1, list.Tail);

            list.PushHead(2);

            Assert.AreEqual(2, list.Head);
            Assert.AreEqual(1, list.Tail);
        }

        [Test]
        public void EmptyList()
        {
            var list = new T();

            Assert.IsTrue(list.Empty);
            Assert.Throws(Is.InstanceOf<Exception>(), () => { var _ = list.Head; });
            Assert.Throws(Is.InstanceOf<Exception>(), () => { var _ = list.Tail; });
            Assert.Throws(Is.InstanceOf<Exception>(), () => list.PopHead());
            Assert.Throws(Is.InstanceOf<Exception>(), () => list.PopTail());
        }

        [Test]
        public void SequentialPush()
        {
            var list = new T();

            list.PushHead(1);

            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(1, list.Tail);

            list.PushTail(2);

            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(2, list.Tail);

            list.PushHead(3);

            Assert.AreEqual(3, list.Head);
            Assert.AreEqual(2, list.Tail);

            list.PushTail(4);

            Assert.AreEqual(3, list.Head);
            Assert.AreEqual(4, list.Tail);

            list.PushHead(5);

            Assert.AreEqual(5, list.Head);
            Assert.AreEqual(4, list.Tail);
        }

        [Test]
        public void TestEnumerator()
        {
            var list = new T();

            list.PushHead(2);
            list.PushTail(3);
            list.PushTail(4);
            list.PushTail(5);
            list.PushHead(1);

            var expected = 1;
            foreach (var item in list)
            {
                Assert.AreEqual(expected, item);
                expected++;
            }
        }

        [Test]
        public void PopHead()
        {
            var list = new T();
            list.PushTail(1);
            list.PushTail(2);
            list.PushTail(3);
            list.PushTail(4);
            list.PushTail(5);

            Assert.AreEqual(1, list.PopHead());
            Assert.AreEqual(2, list.PopHead());
            Assert.AreEqual(3, list.PopHead());
            Assert.AreEqual(4, list.PopHead());
            Assert.AreEqual(5, list.PopHead());
            Assert.IsTrue(list.Empty);
        }

        [Test]
        public void PopTail()
        {
            var list = new T();
            list.PushTail(1);
            list.PushTail(2);
            list.PushTail(3);
            list.PushTail(4);
            list.PushTail(5);

            Assert.AreEqual(5, list.PopTail());
            Assert.AreEqual(4, list.PopTail());
            Assert.AreEqual(3, list.PopTail());
            Assert.AreEqual(2, list.PopTail());
            Assert.AreEqual(1, list.PopTail());
            Assert.IsTrue(list.Empty);
        }

        [Test]
        public void PopSequential()
        {
            var list = new T();
            list.PushTail(1);
            list.PushTail(2);
            list.PushTail(3);
            list.PushTail(4);
            list.PushTail(5);

            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(5, list.Tail);
            Assert.AreEqual(1, list.PopHead());
            Assert.AreEqual(2, list.Head);
            Assert.AreEqual(5, list.Tail);
            Assert.AreEqual(5, list.PopTail());
            Assert.AreEqual(2, list.Head);
            Assert.AreEqual(4, list.Tail);
            Assert.AreEqual(2, list.PopHead());
            Assert.AreEqual(3, list.Head);
            Assert.AreEqual(4, list.Tail);
            Assert.AreEqual(4, list.PopTail());
            Assert.AreEqual(3, list.Head);
            Assert.AreEqual(3, list.Tail);
            Assert.AreEqual(3, list.PopHead());
            Assert.IsTrue(list.Empty);
        }
    }
}