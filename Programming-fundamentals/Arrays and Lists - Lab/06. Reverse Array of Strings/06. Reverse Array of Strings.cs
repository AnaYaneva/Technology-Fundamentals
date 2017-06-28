using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string[] rev = new string[input.Length];

            for (int j = 0; j < input.Length; j++)

            {
                rev[j] = input[input.Length-j-1];
             }
            Console.WriteLine(string.Join(" ",rev));
        }
    }
}