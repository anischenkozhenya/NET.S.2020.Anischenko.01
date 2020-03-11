using System;
using NUnit.Framework;
using Sorting;

namespace Tests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void EvenArray()
        {
            var unSortedArray = new int[] { 8, 3, 2, 4, 5, 6, 1, 7 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var actual = QuickSort.QuickSortMethod(unSortedArray);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddArray()
        {
            var unSortedArray = new int[] { 8, 3, 2, 5, 6, 1, 7 };
            var expected = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            var actual = QuickSort.QuickSortMethod(unSortedArray);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NullReference()
        {
            int[] arrayWithoutRef = null;
            Assert.Throws<NullReferenceException>(() => QuickSort.QuickSortMethod(arrayWithoutRef));
        }
    }
}