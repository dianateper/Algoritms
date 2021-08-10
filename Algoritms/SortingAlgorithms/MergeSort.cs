using System.Linq;

namespace Algoritms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n*log(n)).
    /// Average complexity: O(n*log(n)).
    /// Best complexity: O(n*log(n)).
    /// Space complexity: O(n).
    /// </summary>
    class MergeSort : ISort
    {
        public int[] Divide(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            var firstArray = Divide(array.Take(array.Length - array.Length / 2).ToArray()); 
            var secondArray = Divide(array.Skip(array.Length/2 + array.Length%2).Take(array.Length - array.Length/2).ToArray());

            return Merge(firstArray, secondArray);
        }

        public int[] Merge(int[] firstArray, int[] secondArray)
        {
            var result = new int[firstArray.Length + secondArray.Length];
            var position = 0;

            int i = 0;
            int j = 0;

            while (i < firstArray.Length && j < secondArray.Length) 
            {
                if(firstArray[i] < secondArray[j])
                {
                    result[position] = firstArray[i];
                    i++;
                }
                else
                {
                    result[position] = secondArray[j];
                    j++;
                }

                position++;
            }

            while(i < firstArray.Length)
            {
                result[position] = firstArray[i];
                position++;
                i++;
            }

            while (j < secondArray.Length)
            {
                result[position] = secondArray[j];
                position++;
                j++;
            }

            return result;
        }

        public int[] Sort(int[] array)
        { 
            return Divide(array);
        }
    }
}
