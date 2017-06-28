using System;

namespace _07.Sum_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int len1 = input1.Length;
            int[] arr1 = new int[len1];

            for (int i = 0; i < len1; i++)
            {
                arr1[i] = int.Parse(input1[i]);
            }

            string[] input2 = Console.ReadLine().Split(' ');
            int len2 = input2.Length;
            int[] arr2 = new int[len2];

            for (int i = 0; i < len2; i++)
            {
                arr2[i] = int.Parse(input2[i]);
            }

            int maxLen = len1;
            if (len2>len1)
            {
                maxLen = len2;
            }

            int[] res = new int[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                res[i]=arr1[i % len1] + arr2[i % len2];
            }

            Console.WriteLine(string.Join(" ",res));
        }
    }
}