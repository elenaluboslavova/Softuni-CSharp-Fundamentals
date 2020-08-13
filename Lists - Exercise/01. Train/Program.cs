using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandList = command.Split().ToList();

                if (commandList[0] == "Add")
                {
                    list.Add(int.Parse(commandList[1]));
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + int.Parse(commandList[0]) <= maxCapacity)
                        {
                            list[i] += int.Parse(commandList[0]);
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
        
    }
}
