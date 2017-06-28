﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write program to enter an integer number of centuries and convert it to years, days, hours and minutes.*/
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",centuries,years,days,hours,minutes);
        }
    }
}