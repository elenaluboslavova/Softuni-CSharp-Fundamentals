using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> commandList = command.Split().ToList();

                if (commandList[0] == "Delete")
                {
                    int number = int.Parse(commandList[1]);
                    list.RemoveAll(item => item == number);
                }
                else
                {
                    list.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
