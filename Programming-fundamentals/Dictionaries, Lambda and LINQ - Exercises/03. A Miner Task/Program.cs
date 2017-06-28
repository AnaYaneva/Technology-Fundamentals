using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string commandEntry = Console.ReadLine();


            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> resourse = new List<string>();
            List<int> quantity = new List<int>();
            int counter =0;

            while (!commandEntry.Equals("stop"))
            {
                resourse.Add(commandEntry);
                counter +=1;
                commandEntry = Console.ReadLine();
            }

            for (int i = 0; i < counter;i++)
            {
                if (i % 2 ==1)
                {
                    quantity.Add(int.Parse(resourse[i]));
                    resourse[i] = "";
                }
            }
            for (int i = 0; i < counter/2; i++)
            {
                resourse.Remove("");
            }
            for (int i = 0; i < counter/2; i++)
            {
                if (dict.ContainsKey(resourse[i]))
                {
                    dict[resourse[i]] += quantity[i];
                }
                else
                {
                    dict[resourse[i]] = quantity[i];
                }
            }

            foreach (KeyValuePair<string,int> pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}