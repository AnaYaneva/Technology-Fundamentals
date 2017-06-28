using System;

namespace _04.Tripple_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] num = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i]);
            }

            bool findTriple = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    for (int k = 0; k < input.Length; k++)
                    {
                        if (num[i]+num[j]==num[k])
                        {
                            findTriple = true;
                            Console.WriteLine($"{num[i]} + {num[j]} == {num[k]}");
                            break;
                        }
                        
                    }
                }
            }
           if (findTriple==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}