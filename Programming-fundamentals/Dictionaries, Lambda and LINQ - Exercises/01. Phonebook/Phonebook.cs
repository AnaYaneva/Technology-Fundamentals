using System;
using System.Collections.Generic;

namespace _01.Phonebook
{
    public class Phonebook
    {
        public static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Dictionary<string, string> phonebookS = new Dictionary<string, string>();

            while (commandLine != "END")
            {

                string[] input = commandLine.Split();
                string value = "";
                switch (input[0])
                {
                    case "A":
                        phonebook[input[1]]= input[2];
                        break;

                    case "S":
                        if (!phonebook.TryGetValue(input[1], out value))
                        {
                          phonebookS.Add(input[1], "False");
                        }
                        else
                        {
                            phonebookS.Add(input[1], value);
                        }
                        break;
                }
                commandLine = Console.ReadLine();
            }

            //foreach (KeyValuePair<string, string> pair in phonebookS)
            //{
            //    if (pair.Value.Equals("False"))
            //    {
            //        Console.WriteLine($"Contact {pair.Key} does not exist.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{pair.Key} -> {pair.Value}");
            //    }
            //}
                
              
        }
    }
}