using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program to enter a radius r (real number) and print the area of the circle with exactly 12 digits after the decimal point. Use data type of enough precision to hold the results.

            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", r*r*Math.PI);
        }
    }
}
