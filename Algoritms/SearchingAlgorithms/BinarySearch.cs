using Algorithms.SortingAlgorithms;

namespace Algorithms.SearchingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(log2(n)).
    /// Average complexity: O(log2(n)).
    /// Best complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    class BinarySearch : ISearch
    {
        public ISort Sort = new InsertionSort(); 

        public int Search(int[] array, int target)
        {
            array = Sort.Sort(array);
            var left = 0;
            var right = array.Length;
            
            while(left < right)
            {
                var index = (left + right) / 2;

                if (array[index] == target)
                {
                    return index;
                }

                if (array[index] > target)
                {
                    right = index;
                }
                else
                {
                    left = index;
                }
            }

            return -1;
        }
    }
}
