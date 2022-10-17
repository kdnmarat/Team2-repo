using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    public static class ArraySorter
    {
        // Function that just prints the array
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Printing the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element {i+1}: {array[i],5}");
            }
        }

        // Function that allows the user to create and populate an array of Integers
        public static int[] PopulateArray()
        {
            Console.WriteLine("Please enter the array's size:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            // populating the array by asking the user to enter corresponding values
            Console.WriteLine("Plese enter the values of the array's:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        // Function that sorts the input array of Integers from lower to higher and returns it
        public static int[] SortAscending(int[] array)
        {
            // sorting
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        // Function that sorts the input array of Integers from higher to lower and returns it
        public static int[] SortDescending(int[] array)
        {
            int[] arrReverse = new int[array.Length];
            int j = 0;
            // sorting
            for(int i = array.Length - 1; i >=0; i--)
            {
                arrReverse[j] = array[i];
                j++;
            }
            return arrReverse;
        }
    }
}
