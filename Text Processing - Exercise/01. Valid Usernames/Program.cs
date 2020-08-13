using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                int count = 0;
                string username = input[i];

                if (username.Length >= 3 && username.Length <= 16)
                {
                    for (int j = 0; j < username.Length; j++)
                    {
                        if (char.IsLetterOrDigit(username[j]) || username[j] == '-' || username[j] == '_')
                        {
                            count++;
                        }
                    }
                    if (count == username.Length)
                    {
                        Console.WriteLine(username);
                    }
                }
                
            }
        }
    }
}
