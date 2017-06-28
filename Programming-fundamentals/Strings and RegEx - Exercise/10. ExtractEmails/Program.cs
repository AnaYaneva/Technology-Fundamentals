using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10.ExtractEmails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<!\S)(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z]+([\.a-z]+)?))\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}