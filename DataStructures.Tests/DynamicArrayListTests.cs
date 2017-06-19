using System.Collections.Generic;
using DataStructures.Core.Contracts;
using DataStructures.Tests.Contracts;
using NUnit.Framework;

namespace DataStructures.Tests
{
    public class DynamicArrayList : List<int>, IDynamicArray<int>
    {
    }

    [TestFixture]
    public class DynamicArrayListTests : IDynamicArrayTests<DynamicArrayList>
    {
    }
}