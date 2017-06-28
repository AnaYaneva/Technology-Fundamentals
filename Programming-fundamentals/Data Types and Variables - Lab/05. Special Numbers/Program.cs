using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int num = i; int sum = 0;
                bool special = false;

                while (num>0)
                {
                    num = num % 10;
                    sum += num;
                    num = num / 10;

                }
             
                    special = (sum == 5 || sum == 7 || sum == 11);
                    Console.WriteLine("{0} -> {1}",i,special);
            }
        }
    }
}
