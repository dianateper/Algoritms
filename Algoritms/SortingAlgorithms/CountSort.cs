using System.Collections.Generic;
using System.Linq;

namespace Algorithms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n + k).
    /// Average complexity: O(n + k).
    /// Best complexity: O(n + k).
    /// Space complexity: O(n + k).
    /// </summary>
    class CountSort : ISort
    {
        public int[] Sort(int[] array)
        {
            List<int> countings = new List<int>();

            foreach(var el in Enumerable.Range(0, array.Max() + 1))
            {
                countings.Add(array.Count(x => x == el));
            }

            for(int i = 1; i<countings.Count; i++)
            {
                countings[i] += countings[i - 1];
            }

            int[] result = new int[array.Length];
            for(int i = array.Length - 1; i >= 0; i--)
            {
                result[countings[array[i]] - 1] = array[i];
                countings[array[i]]--;
            }
           
            return result.ToArray();
        }
    }
}
