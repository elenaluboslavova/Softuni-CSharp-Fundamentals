using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                List<string> list = input.Split().ToList();
                string command = list[0];

                if (command == "Urgent")
                {
                    string item = list[1];
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }

                else if (command == "Unnecessary")
                {
                    string item = list[1];
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }

                else if (command == "Correct")
                {
                    string oldItem = list[1];
                    string newItem = list[2];
                    if (groceries.Contains(oldItem))
                    {
                        int index = groceries.IndexOf(oldItem);
                        groceries.Remove(oldItem);
                        groceries.Insert(index, newItem);
                    }
                }

                else if (command == "Rearrange")
                {
                    string item = list[1];
                    if (groceries.Contains(item))
                    {
                        string temp = item;
                        groceries.Remove(item);
                        groceries.Add(temp);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
