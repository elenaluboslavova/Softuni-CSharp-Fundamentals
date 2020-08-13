using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string command = input[0];
                string user = input[1];

                if (command == "register")
                {
                    string number = input[2];
                    if (!dict.ContainsKey(user))
                    {
                        dict.Add(user, number);
                        Console.WriteLine($"{user} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                }

                else if (command == "unregister")
                {
                    if (!dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        dict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

            foreach(var pair in dict)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
