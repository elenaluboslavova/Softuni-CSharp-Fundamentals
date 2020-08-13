using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }

            if (newNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                newNumbers.Reverse();
                Console.WriteLine(string.Join(" ", newNumbers));
            }
        }
    }
}
