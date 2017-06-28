using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters first name, last name and age and prints 
            //"Hello, <first name> <last name>. You are <age> years old.". 
            //Use interpolated strings.

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
        }
    }
}
