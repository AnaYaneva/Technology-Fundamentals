using System;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());

            if (n>0&&n<8)
            {
                Console.WriteLine(day[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}