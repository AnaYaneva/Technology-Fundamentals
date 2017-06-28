using System;
using System.IO;

namespace _04.Merge_Files
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines("FileOne.txt");
            string[] input2 = File.ReadAllLines("FileTwo.txt");

            File.WriteAllText("Output.txt", "");

            for (int i = 0; i < input1.Length; i++)
            {
                File.AppendAllText("Output.txt", $"{input1[i]}\r\n");
                File.AppendAllText("Output.txt", $"{input2[i]}\r\n");
            }

        }
    }
}