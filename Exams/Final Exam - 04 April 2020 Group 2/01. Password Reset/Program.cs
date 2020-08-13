using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                List<string> list = command.Split().ToList();

                string action = list[0];

                if (action == "TakeOdd")
                {
                    string newPassword = string.Empty;
                    for (int i = 1; i <= password.Length - 1; i+=2)
                    {
                        newPassword += password[i];
                    }
                    password = newPassword;
                    Console.WriteLine(password);
                }

                else if (action == "Cut")
                {
                    int index = int.Parse(list[1]);
                    int length = int.Parse(list[2]);

                    if (index + length >= password.Length)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }

                else if (action == "Substitute")
                {
                    string substring = list[1];
                    string substitute = list[2];

                    if (password.Contains(substring))
                    {
                        while (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                        }
                        
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");

        }
    }
}
