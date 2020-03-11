namespace Sorting
{
    /// <summary>
    /// Static class for merge sorting
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// Returns an array sorted by merge sorting
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <returns>Sorted array</returns>
        public static int[] MergeSortMethod(int[] array)
        {
            return MergeSortMethod(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Returns an array, sorted by merge sorting, in the range from minIndex to maxIndex
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <param name="minIndex">Initial index in the range</param>
        /// <param name="maxIndex">Final index in the range</param>
        /// <returns>Sorted array</returns>
        private static int[] MergeSortMethod(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                var middleIndex = (minIndex + maxIndex) / 2;
                MergeSortMethod(array, minIndex, middleIndex);
                MergeSortMethod(array, middleIndex + 1, maxIndex);
                Merge(array, minIndex, middleIndex, maxIndex);
            }
            return array;
        }

        /// <summary>
        /// Merges arrays
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <param name="minIndex">Initial index in the range</param>
        /// <param name="middleIndex">Middle index in the range</param>
        /// <param name="maxIndex">Final index in the range</param>
        private static void Merge(int[] array, int minIndex, int middleIndex, int maxIndex)
        {
            var left = minIndex;
            var right = middleIndex + 1;
            var tempArray = new int[maxIndex - minIndex + 1];
            var index = 0;
            while ((left <= middleIndex) && (right <= maxIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }
            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = right; i <= maxIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            for (var i = 0; i < tempArray.Length; i++)
            {
                array[minIndex + i] = tempArray[i];
            }
        }
    }
}
