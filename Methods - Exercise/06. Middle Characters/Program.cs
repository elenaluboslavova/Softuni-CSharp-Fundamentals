using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintChar(text);
        }

        static void PrintChar(string text)
        {
            char ch1 = text[text.Length / 2];
            char ch2 = text[(text.Length / 2) - 1];
            if (text.Length % 2 == 1)
            {
                Console.WriteLine(ch1);
            }
            else
            {
                Console.Write($"{ch2}{ch1}");
            }

        }
    }
}
