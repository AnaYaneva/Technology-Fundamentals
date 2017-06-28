using System;

namespace _1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*•	On the first line of input you will get the length of the marathon in days
            •	On the second line of input you will get the number of runners that will participate
            •	On the third line you will get the average number of laps every runner makes
            •	On the fourth line you will get the length of the track
            •	On the fifth line you will get the capacity of the track
            •	On the sixth line you will get the amount of money donated per kilometer
            */

            long lenInDays = long.Parse(Console.ReadLine());
            long runnersAll = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lenOfTrack = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long maxRunners;
            if (trackCapacity*lenInDays<runnersAll)
            {
                maxRunners = (long)(trackCapacity * lenInDays);
            }
            else
            {
                maxRunners = runnersAll;
            }

            long totalMeters = (long)(maxRunners * laps * lenOfTrack);
            long totalKm = (long)totalMeters / 1000;
            decimal money = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {money:f2}");

        }
    }
}