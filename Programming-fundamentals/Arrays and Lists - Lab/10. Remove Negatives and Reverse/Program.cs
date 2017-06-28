using System;
using System.Collections.Generic;

namespace _10.Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int len = input1.Length;
            List<int> nums = new List<int>();

            for (int i = 0; i < len; i++)
            {
                nums.Add(int.Parse(input1[i]));
            }
            List<int> numsRev = new List<int>();
            int counter = 0;

            for (int i = len-1; i >=0; i--)
            {
                if (nums[i]>0)
                {
                    numsRev.Add(nums[i]);
                    counter += 1;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numsRev));
            }
        }
    }
}