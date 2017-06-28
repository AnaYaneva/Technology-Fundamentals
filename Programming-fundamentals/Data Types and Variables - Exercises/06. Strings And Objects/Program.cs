using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object conc = hello + " " + world;
            string concat = (string)conc;

            Console.WriteLine(concat);
        }
    }
}
