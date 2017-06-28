using System;

namespace _01.Thea_the_Photographer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int pictureTaken = int.Parse(Console.ReadLine());
            int filterTimeInSec = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimeInSec = int.Parse(Console.ReadLine());

            long useful = (long)Math.Ceiling((double)(pictureTaken * filterFactor / 100));
            long filterAll = (long)pictureTaken * filterTimeInSec;
            long uploadAll = (long)useful * uploadTimeInSec;

            long allSecs = filterAll + uploadAll;

            //TimeSpan span = new TimeSpan(0,0, 0, (int)allSecs);

            //Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}",span.Days, span.Hours, span.Minutes, span.Seconds);
            //Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}", allSecs, allSecs, allSecs, allSecs);
            TimeSpan t = TimeSpan.FromSeconds(allSecs);

            string answer = string.Format("{0:D}:{1:D2}:{2:D2}:{3:D2}",
                            t.Days,

                t.Hours,
                            t.Minutes,
                            t.Seconds);
            Console.WriteLine(answer);
        }
    }
}