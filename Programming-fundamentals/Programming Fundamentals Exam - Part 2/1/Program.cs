using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] input=Console.ReadLine()
               //.Replace('.',',')
                .Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            input = input.OrderBy(x => x).ToArray();
            
            string pattern = @"([a-zA-Z]*)([0-9-+\,\.]*)";
            Regex regex = new Regex(pattern);

            foreach (var inp in input)
            {
                MatchCollection matches = regex.Matches(inp);
                string healthCh = "";
                foreach (Match match in matches)
                {
                    healthCh += match.Groups[1];
                }
                
                
                int health = 0;
                for (int i = 0; i < healthCh.Length; i++)
                {
                    health += (int)healthCh[i];
                }
                double damage = 0;

                foreach (Match match in matches)
                {
                    string tmp = match.Groups[2].ToString();
                    if (tmp=="")
                    {
                        damage = 0;
                    }
                    else
                    {

                  
                    string pattern1 = @"([0-9+-\.]*)([\*\/]*)";
                    Regex regex1 = new Regex(pattern1);
                    MatchCollection matches1 = regex1.Matches(tmp);

                        foreach (Match match1 in matches1)
                        {
                            //string dam = match1.Groups[1].ToString();
                            //Console.WriteLine(dam);
                            double dam1 = double.Parse(match1.Groups[1].ToString());


                            string pow = match1.Groups[2].ToString();
                           
                            for (int i = 0; i < pow.Length; i++)
                            {
                                if (pow[i] == '*')
                                {
                                    dam1 *= 2;
                                }

                                else if (pow[i] == '/')
                                {
                                    dam1 /= 2;
                                }
                            }
                            damage += dam1;
                        }
                    }
                }

               Console.WriteLine($"{inp} - { health} health, {damage:f2} damage ");
            }
            
        }
    }
}