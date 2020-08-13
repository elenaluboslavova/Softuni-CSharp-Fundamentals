using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                List<string> list = input.Split(" - ").ToList();

                string command = list[0];
                string item = list[1];

                if (command == "Collect")
                {
                    if (items.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(item);
                    }
                }

                else if (command == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }

                else if (command == "Combine Items")
                {
                    List<string> combiningItems = item.Split(":").ToList();
                    string oldItem = combiningItems[0];
                    string newItem = combiningItems[1];

                    int index = items.IndexOf(oldItem);
                    if (items.Contains(oldItem))
                    {
                        items.Insert(index + 1, newItem);
                    }
                }

                else if (command == "Renew")
                {
                    if (items.Contains(item))
                    {
                        string current = item;
                        items.Remove(item);
                        items.Add(current);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
