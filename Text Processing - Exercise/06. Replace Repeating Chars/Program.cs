using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                char current = input[i];
                char next = input[i + 1];
                if (current == next)
                {
                    input.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
