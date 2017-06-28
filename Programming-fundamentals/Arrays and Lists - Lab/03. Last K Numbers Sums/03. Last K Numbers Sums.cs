using System;

namespace _03.Last_K_Numbers_Sums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            num[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i < k)
                {
                    for (int j =0; j < i; j++)
                    {
                        num[i] += num[j];
                    }
                }
                else
                {
                    for (int j = i-k; j < i; j++)
                    {
                        num[i] += num[j];
                    }
                }
                
            }
            foreach (var item in num)
            {
                Console.Write($"{item} ");
            }
           
        }
    }
}