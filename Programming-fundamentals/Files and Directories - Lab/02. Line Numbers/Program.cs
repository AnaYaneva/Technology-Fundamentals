using System;
using System.IO;

namespace _02.Line_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[]  text= File.ReadAllLines("input.txt");
            File.WriteAllText("output.txt", "");

            for (int i=0;i< text.Length;i++)
            {
                File.AppendAllText("output.txt", $"{i+1}. {text[i]}\r\n");
            }

        }
    }
}