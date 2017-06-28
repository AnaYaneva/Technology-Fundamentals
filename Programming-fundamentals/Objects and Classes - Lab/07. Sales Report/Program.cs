using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double Profit()
        {
            return Price * Quantity;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            SortedDictionary<string, double> allSales = new SortedDictionary<string, double>();
            foreach (var sale in sales)
            {
                if (allSales.ContainsKey(sale.Town))
                {
                    allSales[sale.Town] += sale.Price * sale.Quantity;
                }
                else
                {
                    allSales[sale.Town] = sale.Profit();
                }
            }
            foreach (KeyValuePair<string,double> pair in allSales)
            {
                Console.WriteLine("{0} -> {1:N2}",pair.Key,pair.Value);
            }
        }

        private static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split();
            Sale sale = new Sale();
            sale.Town = input[0];
            sale.Product = input[1];
            sale.Price = double.Parse(input[2]);
            sale.Quantity = double.Parse(input[3]);

            return sale;
        }
    }
}