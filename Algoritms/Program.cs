using Algoritms.SortingAlgorithms;
using System;

namespace Algoritms
{
    class Program
    {
        public static int[] array = new int[] { 1, 5, 6, 7, 3, 2, 4, 1, 3 };

        public static void Sort(ISort sort)
        {
            var result = sort.Sort(array);

            Console.WriteLine(string.Join(" ", result));
        }

        static void Main()
        {
            Sort(new QuickSort());
        }
    }
}
