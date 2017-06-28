using System;

namespace _08.Condense_Array_to_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int len1 = input1.Length;
            int[] nums = new int[len1];

            for (int i = 0; i < len1; i++)
            {
                nums[i] = int.Parse(input1[i]);
            }
            int len2 = len1 - 1;
            int[] nums1 = new int[len1];
            for (int i = 0; i < len1; i++)
            {
                nums1[i] = nums[i];
            }

            while (len2 > 1)
            {
               
                int[] condensed = new int[len2];

                for (int i = 0; i < len1-1; i++)
                {
                    condensed[i] = nums1[i] + nums1[i + 1];
                }

                len1 = len2;
                len2 = len1 - 1;

                nums1 = new int[len1];
                for (int i = 0; i < len1; i++)
                {
                    nums1[i] = condensed[i];
                }
            }
            foreach (var num in nums1)
            {
                Console.WriteLine(num);
            }
        }
    }
}