using System;
using System.Numerics;

namespace _10.Centuries_to_Nanoseconds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years *365.2422);
            uint hours = days*24;
            long minutes = hours*60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds , 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}