using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string name = string.Empty;
            double grade = 0;

            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }

            var sorted = new Dictionary<string, double>();
            foreach(var pair in dict)
            {
                double sum = 0;
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    sum += pair.Value[i];
                }
                double average = sum / pair.Value.Count;
                if (average >= 4.50)
                {
                    sorted.Add(pair.Key, average);
                }
            }
            
            foreach(var items in sorted.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{items.Key} -> {items.Value:F2}");
            }
        }
    }
}
