using System;

using System.Linq;

namespace _02.Trophon_the_Grumpy_Cat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long[] priceRatings = new long[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                priceRatings[i] = long.Parse(input[i]);
            }

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            long sumLeft = 0;
            long sumRight = 0;

            long entryPointPrice = priceRatings[entryPoint];
                


            switch (typeOfItems)
                {
                    case "cheap":
                    switch (typeOfPrice)
                    {
                        case "positive":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x < entryPointPrice).Where(x => x > 0).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x < entryPointPrice).Where(x => x > 0).Sum();
                            break;
                        case "negative":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x < entryPointPrice).Where(x => x < 0).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x < entryPointPrice).Where(x => x < 0).Sum();
                            break;
                        case "all":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x < entryPointPrice).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x < entryPointPrice).Sum();
                            break;
                    }
                    break;

                    case "expensive":
                    switch (typeOfPrice)
                    {
                        case "positive":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x > entryPointPrice).Where(x => x > 0).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x > entryPointPrice).Where(x => x > 0).Sum();
                            break;
                        case "negative":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x > entryPointPrice).Where(x => x < 0).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x > entryPointPrice).Where(x => x < 0).Sum();
                            break;
                        case "all":
                            sumLeft = (long)priceRatings.Take(entryPoint).Where(x => x > entryPointPrice).Sum();
                            sumRight = (long)priceRatings.Skip(entryPoint + 1).Where(x => x > entryPointPrice).Sum();
                            break;
                    }
                    break;
                }

            long sumMax = sumLeft;
            string position = "Left";
            if (sumLeft<sumRight)
            {
                sumMax = sumRight;
                position = "Right";

            }

            Console.WriteLine($"{ position} - {sumMax}");
        }
    }
}