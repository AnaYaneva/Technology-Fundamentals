using System;

namespace _01.Blank_Receipt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();

        }

        private static void PrintFooter()
        { 
           
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00a9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}