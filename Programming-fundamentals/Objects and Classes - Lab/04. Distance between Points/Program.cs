using System;
using System.Linq;

namespace _04.Distance_between_Points
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double dist = CalcDist(p1, p2);
            Console.WriteLine("{0:N3}",dist);
        }

        private static double CalcDist(Point p1, Point p2)
        {
            int deltaX = p2.x - p1.x;
            int deltaY = p2.y - p1.y;
            double dist = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return dist;
        }

        static Point ReadPoint()
        {
            int[] pointCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p = new Point();

            p.x = pointCoord[0];
            p.y = pointCoord[1];

            return p;


        }
    }
}