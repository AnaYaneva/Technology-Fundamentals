using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool m = Convert.ToBoolean(n);
            if (m==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
