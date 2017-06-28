using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string n=Console.ReadLine();
            int m=Convert.ToInt32(n, 16);
            Console.WriteLine(m);
        }
    }
}
