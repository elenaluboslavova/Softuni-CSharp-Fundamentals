using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictPop = new Dictionary<string, int>();
            var dictGold = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sail")
                {
                    break;
                }
                string[] info = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string town = info[0];
                int population = int.Parse(info[1]);
                int gold = int.Parse(info[2]);


                if (!dictPop.ContainsKey(town))
                {
                    dictPop.Add(town, population);
                    dictGold.Add(town, gold);
                }
                else
                {
                    dictPop[town] += population;
                    dictGold[town] += gold;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                List<string> list = input.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = list[0];
                string town = list[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(list[2]);
                    int gold = int.Parse(list[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    dictPop[town] -= people;
                    dictGold[town] -= gold;

                    if (dictGold[town] == 0 || dictPop[town] == 0)
                    {
                        dictGold.Remove(town);
                        dictPop.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else if (command == "Prosper")
                {
                    int gold = int.Parse(list[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        dictGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {dictGold[town]} gold.");
                    }
                }
            }

            if (dictGold.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dictGold.Count} wealthy settlements to go to:");

                foreach (var pair in dictGold.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{pair.Key} -> Population: {dictPop[pair.Key]} citizens, Gold: {pair.Value} kg");
                }
            }
        }
    }
}
