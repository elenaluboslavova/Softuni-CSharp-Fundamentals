using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            List<string> command = Console.ReadLine().Split().ToList();
            while (!command.Contains("end"))
            {
                string comand = command[0];
                int index = int.Parse(command[1]);

                if (comand == "Add")
                {
                    numbers.Add(index);
                }
                else if (comand == "Remove")
                {
                    numbers.Remove(index);
                }
                else if (comand == "RemoveAt")
                {
                    numbers.RemoveAt(index);
                }
                else if (comand == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), index);
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
