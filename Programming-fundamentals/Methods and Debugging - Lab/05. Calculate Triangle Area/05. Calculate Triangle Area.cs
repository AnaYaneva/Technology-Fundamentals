using System;

namespace _05.Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double basetr = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area=GetArea(basetr, height);
            Console.WriteLine(area);


        }
        
        static double GetArea(double basetr, double height)
        {
            return basetr * height/2;
                }
    }
}