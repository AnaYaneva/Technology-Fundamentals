using System;

namespace _02.Randomize_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int j = rnd.Next(0, input.Length - 1);
                string temp = input[i];
                input[i] = input[j];
                input[j] = temp;
            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}