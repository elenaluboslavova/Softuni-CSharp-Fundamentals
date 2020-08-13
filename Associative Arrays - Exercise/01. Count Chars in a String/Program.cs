using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (!dictionary.ContainsKey(word[j]))
                    {
                        dictionary.Add(word[j], 1);
                    }
                    else
                    {
                        dictionary[word[j]]++;
                    }
                }
            }

            foreach(var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
