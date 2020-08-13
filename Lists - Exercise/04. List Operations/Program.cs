using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> commandList = command.Split().ToList();
                string operation = commandList[0];

                switch (operation)
                {
                    case "Add":
                        list.Add(int.Parse(commandList[1]));
                        break;

                    case "Insert":
                        if (int.Parse(commandList[2]) < list.Count && int.Parse(commandList[2]) >= 0)
                        {
                            list.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (int.Parse(commandList[1]) < list.Count && int.Parse(commandList[1]) >= 0)
                        {
                            list.RemoveAt(int.Parse(commandList[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        if (commandList[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(commandList[2]); i++)
                            {
                                int current = list[0];
                                list.RemoveAt(0);
                                list.Add(current);

                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(commandList[2]); i++)
                            {
                                
                                int current = list[list.Count - 1];
                                list.RemoveAt(list.Count - 1);
                                list.Insert(0, current);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
