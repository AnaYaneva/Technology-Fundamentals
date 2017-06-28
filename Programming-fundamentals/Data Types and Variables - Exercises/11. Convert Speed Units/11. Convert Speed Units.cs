using System;

namespace _11.Convert_Speed_Units
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double secondsAll = hours * 3600 + minutes * 60 + seconds;
            double hoursAll = (double)(secondsAll / 3600);
            double metersPerSec = (double)(distMeters / secondsAll);
            double kmPerHour = (double)(distMeters / (1000 * hoursAll));
            double milesPerHour = (double)(kmPerHour * 0.621371);

            Console.WriteLine("{0:0.000000}", metersPerSec);
            Console.WriteLine("{0:0.000000}", kmPerHour);
            Console.WriteLine("{0:0.000000}",milesPerHour);

        }
    }
}