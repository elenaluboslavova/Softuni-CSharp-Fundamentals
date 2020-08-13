using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (command != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, quantity);
                }
                else
                {
                    dict[resource] += quantity;
                }

                command = Console.ReadLine();
            }

            foreach(var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
