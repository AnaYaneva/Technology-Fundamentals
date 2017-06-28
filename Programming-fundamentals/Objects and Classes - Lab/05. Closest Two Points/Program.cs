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
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            ReadAllPoints(points,n);
            Point[] minDistPoints = new Point[2];

            double minDist=CalcMinDist(points, n,  minDistPoints);
            
            Console.WriteLine("{0:N3}", minDist);
            Console.WriteLine($"({minDistPoints[0].x}, {minDistPoints[0].y})");
            Console.WriteLine($"({minDistPoints[1].x}, {minDistPoints[1].y})");
        }

        private static double CalcMinDist(Point[] points, int n, Point[]minDistPoints)
        {
            double minDist = double.MaxValue;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    double dist = CalcDist(points[i],points[j]);
                    if (dist<minDist)
                    {
                        minDist = dist;
                        minDistPoints[0] = points[i];
                        minDistPoints[1] = points[j];
                    }
                }
            }
            return minDist;
        }

        private static void ReadAllPoints(Point[] points,int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
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