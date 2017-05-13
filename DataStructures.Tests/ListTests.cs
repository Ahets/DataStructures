using DataStructures.Core;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void AddElementsToBack()
        {
            var list = new List<int>();

            Assert.IsTrue(list.Empty);

            list.PushTail(1);

            Assert.IsFalse(list.Empty);
            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(1, list.Tail);

            list.PushTail(2);

            Assert.AreEqual(1, list.Head);
            Assert.AreEqual(2, list.Tail);
        }
    }
}
