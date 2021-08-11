using System;
using System.Linq;

namespace Algorithms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n2).
    /// Average complexity: O(n2).
    /// Best complexity: O(n2).
    /// Space complexity: O(1).
    /// </summary>
    class SelectionSort : ISort
    {
        public int[] Sort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                var subArray = array.Skip(i).ToArray();
                var position = Array.IndexOf(subArray, subArray.Min()) + i;

                var temp = array[position];
                array[position] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}
