using System;
using System.Collections.Generic;


namespace _02.Odd_Occurrences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split();

            Dictionary<string,int> dict= new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            List<string> results = new List<string>();

            foreach (var pair in dict)
            {
                if (pair.Value%2==1)
                {
                    results.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",results));
        }
    }
}