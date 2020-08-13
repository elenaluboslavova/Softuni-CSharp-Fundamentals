using System;
using System.Linq;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "For Azeroth")
                {
                    break;
                }
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = commandArray[0];

                if (action == "GladiatorStance")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }

                else if (action == "DefensiveStance")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }

                else if (action == "Dispel")
                {
                    int index = int.Parse(commandArray[1]);
                    char letter = char.Parse(commandArray[2]);

                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("Dispel too weak.");
                        command = Console.ReadLine();
                        continue;
                    }
                    input = input.Replace(input[index], letter);
                    Console.WriteLine("Success!");
                }

                else if (action == "Target")
                {
                    string substring = commandArray[2];

                    if (commandArray[1] == "Change")
                    {
                        string secondSubstring = commandArray[3];

                        input = input.Replace(substring, secondSubstring);
                    }

                    else if (commandArray[1] == "Remove")
                    {
                        int startIndex = input.IndexOf(substring);


                        input = input.Remove(startIndex, substring.Length);
                    }
                    Console.WriteLine(input);
                }

                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
