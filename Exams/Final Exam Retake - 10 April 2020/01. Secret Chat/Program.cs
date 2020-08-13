using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Reveal")
                {
                    break;
                }

                string[] array = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = array[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(array[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }

                else if (command == "Reverse")
                {
                    string substring = array[1];
                    if (message.Contains(substring))
                    {
                        string reversed = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex);
                        message += reversed;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command == "ChangeAll")
                {
                    string substring = array[1];
                    string replacement = array[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
