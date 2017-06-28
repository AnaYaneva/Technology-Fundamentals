using System;

namespace ConsoleApplication12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Въведете брой елементи на масива: ");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            //1.
            EnterElements(arr);
            Console.WriteLine("Първоначален масив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                    Console.WriteLine(arr[i]);
            }
            //2.
            long mul = Mul(arr);
            Console.WriteLine("mul= {0}",mul);
            //3.
            Console.WriteLine("Елементи на масива по-малки от mul: ");
            PrintLessThanN(arr, mul);
        }

        private static void PrintLessThanN(int[] arr, long n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < n)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

       private static int Mul(int[] arr)
        {
            int mul = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > 10)
                {
                    mul *= arr[i];
                }
            }
            return mul;
        }

        private static void EnterElements(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 50);
            }
        }
    }
}