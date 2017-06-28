using System;

namespace _07.Greater_of_Two_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(input1);
                    int num2 = int.Parse(input2);
                    int max1=GetMax(num1,num2);
                    Console.WriteLine(max1);
                    break;
                case "char":
                    char ch1 = char.Parse(input1);
                    char ch2 = char.Parse(input2);
                    char max2 = GetMax(ch1, ch2);
                    Console.WriteLine(max2);
                    break;
                case "string":
                    string max3 = GetMax(input1, input2);
                    Console.WriteLine(max3);
                    break;
            }
        }

        public static string GetMax(string input1, string input2)
        {
            string res=input1;
            if (input1.CompareTo(input2) > 1);
            {
                res= input2;
            }
                return res;
        }

        private static char GetMax(char ch1, char ch2)
        {
            char res = ch1;
            if (ch1.CompareTo(ch2) > 1);
            {
                res= ch2;
            }
            
                return res;     
        }

        private static int GetMax(int num1, int num2)
        {
            int max = num1;
            if (num1<num2)
            {
                max = num2;
            }
            return max;
        }
    }
}