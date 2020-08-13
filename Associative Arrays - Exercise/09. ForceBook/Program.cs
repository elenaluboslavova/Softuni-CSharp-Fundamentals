using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var dict = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                string[] input = command.Split().ToArray();

                if (input[1] == "|")
                {
                    string side = input[0];
                    string user = input[2];

                    if (dict.Count == 0)
                    {
                        dict.Add(side, new List<string>());
                        dict[side].Add(user);
                    }
                    if (!dict.ContainsKey(side))
                    {
                        dict.Add(side, new List<string>());
                    }
                    foreach (var pair in dict)
                    {
                        if (!pair.Value.Contains(user))
                        {
                            dict[side].Add(user);
                        }
                    }
                }

                else if (input[1] == "->")
                {
                    string user = input[0];
                    string side = input[2];

                    foreach(var pair in dict)
                    {
                        if (pair.Value.Contains(user))
                        {
                            pair.Value.RemoveAll(x => x.Equals(user));

                        }
                    }
                    dict[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

                command = Console.ReadLine();
            }

            foreach(var pair in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                if (pair.Value.Count > 0)
                {
                    foreach (var item in pair.Value)
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
                
            }
        }
    }
}
