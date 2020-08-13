using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string name = string.Empty;
            int age = 0;

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                for (int j = 0; j < input.Count; j++)
                {
                    if (input[j].StartsWith('@'))
                    {
                        name = input[j].Substring(1, input[j].Length - 2);
                    }
                    else if (input[j].StartsWith('#'))
                    {
                        string ageToString = input[j].Substring(1, input[j].Length - 2);
                        age = int.Parse(ageToString);
                    }

                }
                dict.Add(name, age);
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} is {pair.Value} years old.");
            }
        }
    }
}
