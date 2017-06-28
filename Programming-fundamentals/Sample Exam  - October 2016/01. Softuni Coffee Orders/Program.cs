using System;
using System.Globalization;
using System.Linq;

namespace _01.Softuni_Coffee_Orders
{
    public class Order
    {
        public decimal pricePerCapsule { get; set; }
        public string orderDateStr { get; set; }
        public uint capsulesCount { get; set; }

        public DateTime OrderDate
        {
            get
            {
                return DateTime.ParseExact(orderDateStr, "d/M/yyyy", CultureInfo.InvariantCulture);
            }
        }

        public int DaysInMonth
        {
            get 
            {
                return DateTime.DaysInMonth(OrderDate.Year, OrderDate.Month);
            }
        }

        public decimal PriceForCoffee
        {
            get
            {
                return (decimal)((DaysInMonth * capsulesCount) * pricePerCapsule);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Order[] orders = new Order[n];
            for (int i = 0; i < n; i++)
            {
                orders[i]=ReadOrder();
            }
            foreach (var order in orders)
            {
                Console.WriteLine("The price for the coffee is: ${0:F2}", order.PriceForCoffee);
            }
            Console.WriteLine("Total: ${0:F2}", orders.Sum(x => x.PriceForCoffee));
        }

        private static Order ReadOrder()
        {
           
                Order order = new Order();
            order.pricePerCapsule = decimal.Parse(Console.ReadLine());
            order.orderDateStr = Console.ReadLine();
            order.capsulesCount = uint.Parse(Console.ReadLine());

            return order;
            
        }
    }
}