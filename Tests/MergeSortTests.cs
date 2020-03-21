using Sorting;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void MergeSortMethodEvenArray()
        {
            var unSortedArray = new int[] { 8, 3, 2, 4, 5, 6, 1, 7 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var actual = MergeSort.MergeSortMethod(unSortedArray);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MergeSortMethodAddArray()
        {
            var unSortedArray = new int[] { 8, 3, 2, 5, 6, 1, 7 };
            var expected = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            var actual = MergeSort.MergeSortMethod(unSortedArray);
            Assert.AreEqual(expected, actual);
        }
    }
}