using System;
using System.Collections.Generic;


namespace _01.CountRealNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');

            var dict = new SortedDictionary<double, int>();

            foreach (var item in strings)
            {
                double parsedNum = double.Parse(item);
                if (dict.ContainsKey(parsedNum))
                {
                    dict[parsedNum] += 1;
                }
                else
                {
                    dict[parsedNum] = 1;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }

        }
    }
}