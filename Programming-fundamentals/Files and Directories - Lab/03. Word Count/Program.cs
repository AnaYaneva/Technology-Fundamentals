using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.Word_Count
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText("text.txt").ToLower();
            string[] input = text.Split(new char[] { '\r','\n',' ', ',', '.', '-', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string[] words = File.ReadAllText("words.txt").Split(' ');

            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (var word in words)
            {
                counter[word] = 0;
            }
            foreach (var word in input)
            {
                if (counter.ContainsKey(word))
                {
                    counter[word] += 1;
                }
                
            }
         

            counter = counter.OrderByDescending(w => w.Value).ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllText("output.txt", "");

            foreach (KeyValuePair<string,int> pair in counter)
            {
                //Console.WriteLine($"{pair.Key} - {pair.Value}\r\n");
                File.AppendAllText("output.txt", $"{pair.Key} - {pair.Value}\r\n");
            }
        }
    }
}