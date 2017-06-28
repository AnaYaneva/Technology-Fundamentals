using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dateInput = Console.ReadLine();
            DateTime dayOfWeek = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}