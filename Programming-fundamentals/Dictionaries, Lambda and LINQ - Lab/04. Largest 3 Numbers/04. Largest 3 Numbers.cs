using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Largest_3_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                                    .Split()
                                    .Select(double.Parse)
                                    .ToArray();
           nums=nums.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ",nums));

        }
    }
}