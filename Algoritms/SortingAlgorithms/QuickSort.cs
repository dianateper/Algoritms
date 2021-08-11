namespace Algorithms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n2).
    /// Average complexity: O(n*log(n)).
    /// Best complexity: O(n*log(n)).
    /// Space complexity: O(log(n)).
    /// </summary>
    class QuickSort : ISort
    { 
        int[] Partition(int[] array, int left, int right, out int pivotIndex)
        {
            var pivot = array[right];
           
            for (int i = left; i<right; i++)
            {
                if(array[i] >= pivot)
                {
                    var temp = array[i];
                    array[i] = array[right];
                    array[right] = temp;
                    i--;
                    right--;
                }
            }

            pivotIndex = right;

            return array;
        }
        
        int[] Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                array = Partition(array, left, right, out int pivotIndex);

                array = Sort(array, left, pivotIndex - 1);
                array = Sort(array, pivotIndex + 1, right);
            }

            return array;
        }

        public int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }
    }
}
