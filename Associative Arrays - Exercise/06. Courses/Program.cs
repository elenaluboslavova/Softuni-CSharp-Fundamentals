using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var dictionary = new Dictionary<string, List<string>>();

            string course = string.Empty;
            string student = string.Empty;

            while (command != "end")
            {
                string[] input = command.Split(" : ").ToArray();
                course = input[0];
                student = input[1];

                if (!dictionary.ContainsKey(course))
                {
                    dictionary.Add(course, new List<string>());
                    dictionary[course].Add(student);
                }
                else
                {
                    dictionary[course].Add(student);
                }

                command = Console.ReadLine();
            }

            foreach(var items in dictionary.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{items.Key}: {items.Value.Count}");
                foreach(var elements in items.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {elements}");
                }
            }
        }
    }
}
