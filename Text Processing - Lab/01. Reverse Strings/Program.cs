using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var dict = new Dictionary<string, string>();

            while (command != "end")
            {
                string word = string.Empty;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    word += command[i];
                }

                dict.Add(command, word);

                command = Console.ReadLine();
            }

            foreach(var pair in dict)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}
