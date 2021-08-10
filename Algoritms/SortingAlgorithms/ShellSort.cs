using System;
using System.Linq;

namespace Algoritms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n2).
    /// Best complexity: O(n*log2(n)).
    /// Space complexity: O(n).
    /// </summary>
    class ShellSort : ISort
    {
        private ISort InsertionSort = new InsertionSort();

        public int[] Sort(int[] array)
        {
            var interval = GetInterval(array);

            while(interval > 0)
            {
                for(int i = 0; i < array.Length; i += interval)
                {
                    var result = InsertionSort.Sort(array.Skip(i).Take(array.Length/interval).ToArray());
                    Array.Copy(result, 0, array, i, result.Length);
                }

                interval = (interval - 1) / 3;
            }

            return array;
        }

        public int GetInterval(int[] array)
        {
            var interval = 0;
            while (interval < array.Length / 3)
            {
                interval = interval * 3 + 1;
            }
            return interval;
        }
    }
}
