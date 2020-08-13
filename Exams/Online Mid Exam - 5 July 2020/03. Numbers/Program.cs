using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double average = list.Sum() * 1.0 / list.Count;

            List<int> topNumbers = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    topNumbers.Add(list[i]);
                }
            }
            topNumbers.Sort();
            topNumbers.Reverse();
            if (topNumbers.Count > 5)
            {
                topNumbers.RemoveRange(5, topNumbers.Count - 5);
            }
            if (topNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topNumbers));
            }
            
        }
    }
}
