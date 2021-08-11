using Algorithms.SortingAlgorithms;

namespace Algorithms.SearchingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(log3(n)).
    /// Average complexity: O(log3(n)).
    /// Best complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    class TernarySearch : ISearch
    {
        ISort InsertionSort = new InsertionSort();

        public int Search(int[] array, int target)
        {
            array = InsertionSort.Sort(array);
            return Search(array, target, 0, array.Length - 1);
        }

        public int Search(int[] array, int target, int left, int right)
        {
            int firstMiddlePosition = left + (right - left) / 3;
            int secondMiddlePosition = firstMiddlePosition + (right - left) / 3;

            if (left > right)
            {
                return -1;
            }

            if (array[firstMiddlePosition] == target)
            {
                return firstMiddlePosition;
            }

            if (array[secondMiddlePosition] == target)
            {
                return secondMiddlePosition;
            }

            if (array[firstMiddlePosition] > target)
            {
                return Search(array, target, left, firstMiddlePosition - 1);
            }

            if (array[secondMiddlePosition] < target)
            {
                return Search(array, target, secondMiddlePosition + 1, right);
            }

            return Search(array, target, firstMiddlePosition + 1, secondMiddlePosition - 1);
        }
    }
}
