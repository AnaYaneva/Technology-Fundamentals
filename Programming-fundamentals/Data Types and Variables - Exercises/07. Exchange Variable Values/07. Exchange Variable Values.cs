using System;

namespace _07.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int temp;
            Console.WriteLine("Before:\na = {0}\nb = {1}",a,b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}