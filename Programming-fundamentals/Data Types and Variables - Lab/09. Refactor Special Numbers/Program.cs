using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int numb; bool special = false;
            for (int i = 1; i <= n; i++)
            {
                numb = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numb, special);
                sum = 0;
                i = numb;
            }

        }
    }
}
