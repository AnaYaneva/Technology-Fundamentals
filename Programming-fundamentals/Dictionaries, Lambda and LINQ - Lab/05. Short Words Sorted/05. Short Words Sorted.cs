using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Short_Words_Sorted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] chars = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] words = Console.ReadLine().ToLower().Split(chars);

            words = words.Where(w => w != "").Where(word => word.Length < 5).OrderBy(w => w).Distinct().ToArray();
            Console.WriteLine(string.Join(", ", words));


        }
    }
}