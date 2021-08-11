using Algorithms.SortingAlgorithms;
using System;

namespace Algorithms.SearchingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(√n).
    /// Average complexity: O(√n).
    /// Best complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    class JumpSearch : ISearch
    {
        ISort InsertionSort = new InsertionSort();
        
        public int Search(int[] array, int target)
        {
            array = InsertionSort.Sort(array);
            int interval = (int)Math.Sqrt(array.Length);
            var index = 0;

            while(index < array.Length && array[index] < target)
            {
                index += interval;
            }

            for(int i = index - interval; i<array.Length && i<index; i++)
            {
                if(array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
