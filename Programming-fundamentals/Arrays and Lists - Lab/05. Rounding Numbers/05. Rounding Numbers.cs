using System;

namespace _05.Rounding_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] num = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = double.Parse(input[i]);
            }

            int[] intNum = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (num[i]<0)
                {
                    intNum[i] = (int)(Math.Floor(num[i]));
                }
                else if (num[i] > 0)
                {
                    intNum[i] = (int)(Math.Ceiling(num[i]));
                }
                else
                {
                    intNum[i] = (int)(num[i]);
                }
                
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {intNum[i]}");
            }
        }
    }
}