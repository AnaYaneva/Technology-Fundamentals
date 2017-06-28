using System;

namespace _03.Printing_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                PrintLine(1, i);
            }
            for (int i=n-1; i>=0; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int j = start; j <=end; j++)
            {
                Console.Write((j) + " ");
            }
            Console.WriteLine();
        }
    }
}