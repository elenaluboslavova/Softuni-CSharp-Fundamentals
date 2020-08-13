using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([=\/])(?<word>[A-ZА-Я]{1}[a-zа-я]{2,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> list = new List<string>();
            int sum = 0;

            foreach (Match match in matches)
            {
                string word = match.Groups["word"].Value;
                list.Add(word);
                sum += word.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
