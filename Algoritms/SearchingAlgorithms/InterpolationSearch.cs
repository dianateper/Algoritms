using Algorithms.SortingAlgorithms;

namespace Algorithms.SearchingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n).
    /// Average complexity: O(loglog(n)).
    /// Best complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    class InterpolationSearch : ISearch
    {
        ISort InsertionSort = new InsertionSort();

        public int Search(int[] array, int target)
        {
            array = InsertionSort.Sort(array);

            var left = 0;
            var right = array.Length - 1;

            
            while(left < right)
            {
                var pos = left + ((target - array[left]) * (right - left) / (array[right] - array[left]));

                if(target == array[pos])
                {
                    return pos;
                }

                if(array[pos] > target)
                {
                    right = pos - 1;
                }
                else
                {
                    left = pos + 1;
                }
            }

            return -1;
        }
    }
}
