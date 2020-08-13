using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<double>>();
            var dictRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string plant = input[0];
                double rarity = double.Parse(input[1]);
                if (!dict.ContainsKey(plant))
                {
                    dict.Add(plant, new List<double>());
                    dict[plant].Add(rarity);
                }
                else
                {
                    dict[plant][0] = rarity;
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandArray = command.Split().ToArray();

                string action = commandArray[0];

                if (action == "Rate:")
                {

                    string plant = commandArray[1];
                    double rating = double.Parse(commandArray[3]);
                    if (!dictRating.ContainsKey(plant))
                    {
                        dictRating.Add(plant, new List<double>());
                        dictRating[plant].Add(rating);
                    }
                    else
                    {
                        dictRating[plant].Add(rating);
                    }
                }

                else if (action == "Update:")
                {
                    string plant = commandArray[1];
                    double rarity = double.Parse(commandArray[3]);
                    dict[plant][0] = rarity;
                }

                else if (action == "Reset:")
                {
                    string plant = commandArray[1];
                    dictRating.Remove(plant);
                    dictRating.Add(plant, new List<double>());
                }

                else
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine();
            }

            foreach (var item in dictRating)
            {
                double average = item.Value.Sum() / item.Value.Count;
                if (item.Value.Count == 0)
                {
                    average = 0;
                }
                dict[item.Key].Add(average);
            }
            Console.WriteLine("Plants for the exhibition:");
            if (dict.Count > 0)
            {
                foreach (var pair in dict.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
                {
                    Console.WriteLine($"- {pair.Key}; Rarity: {pair.Value[0]}; Rating: {pair.Value[1]:F2}");
                }
            }
        }
    }
}
