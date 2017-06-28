using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            List<long> indexes = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(long.Parse)
                            .ToList();



            SortedDictionary<long, long> ladyBugs = new SortedDictionary<long, long>();
            for (long j = 0; j < size; j++)
            {
                {
                    ladyBugs[j] = 0;
                }
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (j == indexes[i])
                    {
                        ladyBugs[j] = 1;
                    }
                }

            }

            //foreach (KeyValuePair<long, long> pair in ladyBugs)
            //{
            //    Console.WriteLine($"{pair.Key}-{pair.Value}");
            //}

            string consoleInput = Console.ReadLine();

            while (!consoleInput.Equals("end"))
            {
                List<string> fieldMoves = consoleInput
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

                long indexStart = long.Parse(fieldMoves[0]);
                string direction = fieldMoves[1];
                long dir = 0;
                switch (direction)
                {
                    case "right":
                        dir = 1;
                        break;
                    case "left":
                        dir = -1;
                        break;
                }
                long step = long.Parse(fieldMoves[2]);
                long indexEnd;


                if (ladyBugs[indexStart] == 1)
                {
                    ladyBugs[indexStart] = 0;

                    indexEnd = dir * step + indexStart;

                    if (indexEnd >= size || indexEnd < 0)
                    {
                        break;
                    }
                   
                    while (ladyBugs[indexEnd] == 1)
                    {
                        indexEnd += 1 * dir;
                        if (indexEnd >= size || indexEnd < 0)
                        {
                            break;
                        }
                    }
                    ladyBugs[indexEnd] = 1;
                }
                consoleInput = Console.ReadLine();
            }

            Console.Write($"{ladyBugs[0]}");
            for (long i = 1; i < size; i++)
            {
                Console.Write(" ");
                Console.Write($"{ladyBugs[i]}");
            }

            Console.WriteLine();

        }
    }
}