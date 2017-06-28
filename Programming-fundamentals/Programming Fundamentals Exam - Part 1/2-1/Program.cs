using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> indexes = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            string consoleInput = Console.ReadLine();

            SortedDictionary<int, int> ladyBugs = new SortedDictionary<int, int>();
            for (int j = 0; j < size; j++)
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

            while (!consoleInput.Equals("end"))
            {
                List<string> fieldMoves = consoleInput
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

                int indexStart = int.Parse(fieldMoves[0]);
                string direction = fieldMoves[1];
                int dir = 0;
                switch (direction)
                {
                    case "right":
                        dir = 1;
                        break;
                    case "left":
                        dir = -1;
                        break;
                }
                int step = int.Parse(fieldMoves[2]);
                int indexEnd;

                SortedDictionary<int, int> temp = new SortedDictionary<int, int>();

                
                if (ladyBugs[indexStart] == 1)
                {
                    temp[indexStart] = 0;

                    indexEnd = dir * step + indexStart;

                    if (indexEnd < ladyBugs.Count - 1 && indexEnd >= 0)
                    {
                        while (ladyBugs[indexEnd] == 1)
                        {
                            if (indexEnd < ladyBugs.Count - 1 && indexEnd >= 0)
                            {
                                indexEnd += 1 * dir;
                            }
                        }
                        
                    }
                    temp[indexEnd] = 1;
                }

                for (int i = 0; i < size; i++)
                {
                    if (temp.ContainsKey(i))
                    {
                        ladyBugs[i] = temp[i];
                    }
                    else
                    {
                        ladyBugs[i] = 0;
                    }

                }

                consoleInput = Console.ReadLine();
            }

            Console.Write($"{ladyBugs[0]}");
            for (int i = 1; i < size; i++)
            {
                Console.Write(" ");
                Console.Write($"{ladyBugs[i]}");
            }

            Console.WriteLine();

            //foreach (KeyValuePair<int, int> pair in ladyBugs)
            //{
            //    Console.WriteLine($"{pair.Key}-{pair.Value}");
            //}
        }
    }
}