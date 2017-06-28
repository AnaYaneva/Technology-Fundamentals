using System;

namespace _04.Draw_a_Filled_Square
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderAndFooter(n);
            PrintBody(n);
            PrintHeaderAndFooter(n);
        }

        private static void PrintBody(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("-");
                for (int j = 0; j <  n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void PrintHeaderAndFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}