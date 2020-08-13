using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> list = input.Split().ToList();

            long sum = 1;
            for (int i = 0; i < list.Count; i++)
            {
                string current = list[i];

                for (int j = 0; j < current.Length; j++)
                {
                    if (char.IsDigit(current[j]))
                    {
                        int digit = int.Parse(current[j].ToString());
                        sum *= digit;
                    }
                }
            }
            Console.WriteLine($"Cool threshold: {sum}");

            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            Regex regex = new Regex(pattern);

            var coolEmojis = new List<string>();
            int counter = 0;
            int coolness = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Match match = regex.Match(list[i]);
                coolness = 0;
                if (match.Success)
                {
                    counter++;
                    string word = match.Value;
                    string emoji = match.Groups["emoji"].Value;
                    for (int j = 0; j < emoji.Length; j++)
                    {
                        coolness += (int)emoji[j];
                    }
                    if (coolness >= sum)
                    {
                        coolEmojis.Add(word);

                    }
                }
            }

            Console.WriteLine($"{counter} emojis found in the text. The cool ones are:");
            foreach(var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
