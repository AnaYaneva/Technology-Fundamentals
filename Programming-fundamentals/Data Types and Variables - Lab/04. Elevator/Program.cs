using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine((int)Math.Ceiling((double)people/capacity));
        }
    }
}
