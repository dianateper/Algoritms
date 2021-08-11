namespace Algorithms.SortingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n2).
    /// Average complexity: O(n2).
    /// Best complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    class BubbleSort : ISort
    {
        public int[] Sort(int[] array)
        {
            for(int i = 0; i<array.Length - 1; i++)
            {
                for(int j = 0; j< array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
