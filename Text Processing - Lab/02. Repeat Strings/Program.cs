using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string newWord = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                for (int j = 0; j < word.Length; j++)
                {
                    newWord += word;
                }
            }
            Console.WriteLine(newWord);
        }
    }
}
