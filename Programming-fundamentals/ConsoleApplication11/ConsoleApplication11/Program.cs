using System;

namespace ConsoleApplication11
{
    class Program
    {
        //a)
        static double Sr(int x, int y)
        {
            return (Math.Abs(x) + Math.Abs(y)) / 2;
        }

        static void Main(string[] args)
        {
            //b)
            Console.Write("Моля, въведете стойност за p в интервала [-10;8]: ");
            int p=int.Parse(Console.ReadLine());
            Console.Write("Моля, въведете стойност за q в интервала [-10;8]: ");
            int q = int.Parse(Console.ReadLine());

            //c)
            double res = (Sr(2*p,3*q)- Sr(3 * p, 2 * q))/ Sr(p, q);

            Console.WriteLine("Търсеният резултат е: "+ res);

            //d)
            for (p = -10; p <=8; p++)
            {
                double s = Sr(p, q);

                if ((s-(int)s)==0 && (int)s%2==1)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}