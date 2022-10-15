using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArraySorter.PopulateArray();
            Console.WriteLine("Unsorted array:");
            ArraySorter.PrintArray(array);

            int[] arraySortedAsc = ArraySorter.SortAscending(array);
            Console.WriteLine("`nSorted in ascending order:");
            ArraySorter.PrintArray(arraySortedAsc);

            int[] arraySortedDesc = ArraySorter.SortDescending(array);
            Console.WriteLine("`nSorted in descending order:");
            ArraySorter.PrintArray(arraySortedDesc);

            Console.ReadLine();
        }
    }
}
