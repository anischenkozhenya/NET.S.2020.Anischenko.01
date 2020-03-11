using System;

namespace Sorting
{
    /// <summary>
    /// Static class for quick sorting
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        /// Returns an array sorted by quick sorting
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <returns>Sorted array</returns>
        public static int[] QuickSortMethod(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }
            return QuickSortMethod(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Returns an array, sorted by quick sorting, in the range from minIndex to maxIndex
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <param name="minIndex">Initial index in the range</param>
        /// <param name="maxIndex">Final index in the range</param>
        /// <returns>Sorted array</returns>
        private static int[] QuickSortMethod(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSortMethod(array, minIndex, pivotIndex - 1);
            QuickSortMethod(array, pivotIndex + 1, maxIndex);
            return array;
        }

        /// <summary>
        /// Returns partition index
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <param name="minIndex">Initial index in the range</param>
        /// <param name="maxIndex">Final index in the range</param>
        /// <returns>Partition index</returns>
        private static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if(array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        /// <summary>
        /// Swaps the values ​​of variables passed by reference
        /// </summary>
        /// <param name="x">First value</param>
        /// <param name="y">Second value</param>
        private static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}
