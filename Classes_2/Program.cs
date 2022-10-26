using System;

namespace Classes_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your favorite car's model: ");
            string str = Console.ReadLine().ToLower();
            switch (str)
            {
                case "opel":
                    Console.WriteLine("Your's favorite car's model - opel");
                    break;
                case "bmw":
                    Console.WriteLine("Your's favorite car's model - BMW");
                    break;
                case "chevrolet":
                case "ford":
                    Console.WriteLine("You are like american cars!");
                    break;
                    default:
                    Console.WriteLine("You didn't enter anything or their models no in our model's list!");
                    break;
            }
        }
    }
}