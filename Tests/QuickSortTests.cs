using NUnit.Framework;
using System;
using System.Collections.Generic;
using Sorting;

namespace Tests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void FullInformation()
        {
            var expected = new int[] {8,3,2,4,5,6,1,7};
            var actual = new int[] {1, 2, 3, 4, 5, 6, 7, 8};

            Assert.AreEqual(expected, actual);
        }
    }
}
