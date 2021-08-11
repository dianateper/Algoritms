namespace Algorithms.SearchingAlgorithms
{
    /// <summary>
    /// Worst complexity: O(n).
    /// Average complexity: O(n).
    /// Best complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    class LinearSearch : ISearch
    {
        public int Search(int[] array, int target)
        {
            for(int i = 0; i<array.Length; i++)
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
