using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static Classes.Program;
using System.Reflection.Metadata.Ecma335;

namespace Classes

{
    class Niz
    {
        static public void Average(int num)
        {
            
            int[] arr = new int[num];
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            int sum = 0;
            int count = 0;
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 5 == 0))
                {
                    if (arr[i] == 0)
                    {
                        continue;
                    }
                    sum += arr[i];
                    count++;
                }

            }
            if (count > 0)
            {
                average = sum / count;
                Console.WriteLine("This'is our array - " + String.Join(", ", arr));
                Console.WriteLine("Average value for values, divisible by 5 without a reminder   - " + average);
            }
                     
            
        }

        static public void SortArray(int num)
        {
            int[] arr = new int[num];
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            Console.WriteLine("This is unsorted array - " + String.Join(", ", arr));
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("This is sorted array - " + String.Join(", ", arr));
        }
        static public void MinMaxValue(int num)
        {
            int[] arr = new int[num];
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            Console.WriteLine("This is our array " + String.Join(", ", arr));
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Minimal array's value is - " + arr[0]);
            Console.WriteLine("Maximal array's value is - " + arr[arr.Length - 1]);
        }
        static public int[] ArrayConcat(int[] a, int[] b)
        {
            // 
            Array.Sort(a);
            Array.Sort(b);

            int[] result = a.Concat(b).ToArray();
            return result;
        }
    }
    public static class Program
    {
        
        static void Main(string[] args)
        {
            int[] one = { 3, 2, 1 };
            int[] two = { 6, 4, 5 };
            Console.WriteLine(String.Join(", ", Niz.ArrayConcat( one, two)));
        }
    }
}