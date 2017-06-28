using System;

namespace _02.Reverse_Array_of_Integers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}