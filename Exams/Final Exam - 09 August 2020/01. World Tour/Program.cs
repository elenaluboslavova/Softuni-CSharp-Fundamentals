using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArray = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = commandArray[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArray[1]);
                    string word = commandArray[2];
                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, word);

                    }
                    Console.WriteLine(stops);
                }

                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArray[1]);
                    int endIndex = int.Parse(commandArray[2]);
                    if ((startIndex >= 0 && startIndex < stops.Length) && (endIndex >= 0 && endIndex < stops.Length))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);

                    }
                    Console.WriteLine(stops);
                }

                else if (action == "Switch")
                {
                    string oldString = commandArray[1];
                    string newString = commandArray[2];
                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);

                    }
                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
