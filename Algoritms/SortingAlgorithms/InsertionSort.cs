namespace Algoritms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n2).
    /// Average complexity: O(n2).
    /// Best complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    class InsertionSort : ISort
    {
        public int[] Sort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int position = i;
                
                while(position > 0 && value < array[position - 1])
                {
                    array[position] = array[position - 1];
                    position--;
                }

                array[position] = value;
            }

            return array;
        }
    }
}
