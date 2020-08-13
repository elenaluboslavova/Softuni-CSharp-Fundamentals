using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contestants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var namesAndKms = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string namePattern = "[A-Za-z]";
                string digitsPattern = @"[\d]";

                var nameMatch = Regex.Matches(input, namePattern);
                var kmMatch = Regex.Matches(input, digitsPattern);

                var name = string.Concat(nameMatch);

                var sumOfKm = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                if (contestants.Contains(name))
                {
                    if (namesAndKms.ContainsKey(name))
                    {
                        namesAndKms[name] += sumOfKm;
                    }
                    else
                    {
                        namesAndKms.Add(name, sumOfKm);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = namesAndKms.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);
        }
    }
}
