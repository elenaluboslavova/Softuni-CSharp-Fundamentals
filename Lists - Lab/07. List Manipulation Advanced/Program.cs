using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string comand = string.Empty;
            List<string> command = Console.ReadLine().Split().ToList();
            while (!command.Contains("end"))
            {
                comand = command[0];

                
                switch (comand)
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        Filter(numbers, command);
                        break;
                }

                command = Console.ReadLine().Split().ToList();
            }
            if (comand == "Add" || comand == "Remove" || comand == "RemoveAt" || comand == "Insert")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void Filter(List<int> numbers, List<string> command)
        {
            int number = int.Parse(command[2]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (command[1] == "<")
                {
                    if (numbers[i] < number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                else if (command[1] == ">")
                {
                    if (numbers[i] > number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                else if (command[1] == ">=")
                {
                    if (numbers[i] >= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                else if (command[1] == "<=")
                {
                    if (numbers[i] <= number)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
