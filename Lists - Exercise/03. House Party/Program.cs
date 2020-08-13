using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];

                if (command[2] == "going!")
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
