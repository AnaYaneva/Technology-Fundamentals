using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string consoleInput = Console.ReadLine();


            Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();
            Dictionary<string, int> count = new Dictionary<string, int>();
            Dictionary<string, string> temp = new Dictionary<string, string>();

            while (consoleInput!= "Time for Code")
            {
                List<string> input = consoleInput
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();
                List<string> participants = new List<string>();
                
                char[] hashtag = input[1].ToCharArray();
                string eventName = "";
                for (int i = 1; i < hashtag.Length; i++)
                {
                    eventName += hashtag[i];  
                }

                if (hashtag[0]!='#')
                {
                    break;
                }

                

                if (temp.ContainsKey(input[0]))
                {
                    if (temp[input[0]]!=eventName)
                    {
                        
                    }
                }
                else
                {
                    temp[input[0]] = eventName;
                }



                for (int i = 2; i < input.Count; i++)
                {
                    participants.Add(input[i]);
                     

                }

                participants = participants.OrderBy(x => x).ToList();

                if (temp.ContainsValue(eventName))
                {
                    if (events.ContainsKey(eventName))
                    {
                        events[eventName].AddRange(participants);
                        events[eventName] = events[eventName].Distinct().ToList();
                    }
                    else
                    {
                        events[eventName] = participants;
                    }
                }

                consoleInput = Console.ReadLine();
                int counter = events[eventName].Count;
                count[eventName] = counter;
            }

            count = count.OrderByDescending(x => x.Value).ToDictionary(p => p.Key, p => p.Value);
            events = events.OrderBy(x => x.Value.OrderBy(y=>y)).ToDictionary(p => p.Key, p => p.Value);
            foreach (KeyValuePair<string,int> item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
                if (temp.ContainsValue(item.Key))
                {
                    foreach (var val in events[item.Key])
                    {
                        Console.WriteLine(val);
                    }
                }
            }


        }
    }
}