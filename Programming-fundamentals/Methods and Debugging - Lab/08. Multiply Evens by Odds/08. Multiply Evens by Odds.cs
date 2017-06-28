using System;

namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            
            GetMultiply(num);
            Console.WriteLine(GetMultiply(num));

        }

        private static int GetMultiply(int num)
        {
            int sumEven = GetSum(num, 0);
            int sumOdd = GetSum(num, 1);
            return sumEven * sumOdd;
        }

        private static int GetSum(int num, int m)
        {
            int sum = 0;
            
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == m)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}