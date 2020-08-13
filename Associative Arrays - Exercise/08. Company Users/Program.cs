using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            string command = string.Empty;
            string company = string.Empty;
            string id = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] input = command.Split(" -> ").ToArray();
                company = input[0];
                id = input[1];

                if (!dict.ContainsKey(company))
                {
                    dict.Add(company, new List<string>());
                }
                if (dict[company].Contains(id))
                {
                    continue;
                }
                dict[company].Add(id);

            }

            foreach(var pair in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key);
                foreach(var item in pair.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
