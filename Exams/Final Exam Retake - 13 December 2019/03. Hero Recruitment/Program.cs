using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var dict = new Dictionary<string, List<string>>();

            string command = input[0];

            while (input[0] != "End")
            {
                command = input[0];
                string hero = input[1];
                if (command == "Enroll")
                {
                    if (!dict.ContainsKey(hero))
                    {
                        dict.Add(hero, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{hero} is already enrolled.");
                    }
                }

                else if (command == "Learn")
                {
                    string spell = input[2];
                    if (!dict.ContainsKey(hero))
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                    }
                    else if (dict[hero].Contains(spell))
                    {
                        Console.WriteLine($"{hero} has already learnt {spell}.");
                    }
                    else
                    {
                        dict[hero].Add(spell);
                    }
                }

                else if (command == "Unlearn")
                {
                    string spell = input[2];
                    if (!dict.ContainsKey(hero))
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                    }
                    else if (!dict[hero].Contains(spell))
                    {
                        Console.WriteLine($"{hero} doesn't know {spell}.");
                    }
                    else
                    {
                        dict[hero].Remove(spell);
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            List<string> list = new List<string>();

            Console.WriteLine("Heroes:");
            foreach (var pair in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.Write($"== {pair.Key}: ");
                foreach (var item in dict[pair.Key])
                {
                    list.Add(item);
                }
                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
