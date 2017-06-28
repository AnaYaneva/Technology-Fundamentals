using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Refactor_Volume_of_Pyramid_
{
    class Program
    {
        static void Main(string[] args)
        {
            double leng, wid, heig;
            double volume = 0;
Console.Write("Length: ");
leng = double.Parse(Console.ReadLine());
Console.Write("Width: ");
wid = double.Parse(Console.ReadLine());
Console.Write("Height: ");
heig = double.Parse(Console.ReadLine());
volume = (leng * wid * heig) / 3;
Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
