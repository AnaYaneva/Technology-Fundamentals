using System;

namespace _09.Reversed_chars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{c}{b}{a}");
        }
    }
}