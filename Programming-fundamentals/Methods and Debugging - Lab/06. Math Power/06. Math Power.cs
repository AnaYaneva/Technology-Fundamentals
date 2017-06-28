using System;

namespace _06.Math_Power
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double area = GetArea(basetr, height);
            Console.WriteLine(area);


        }

        static double GetArea(double basetr, double height)
        {
            return basetr * height / 2;
        }
    }
}