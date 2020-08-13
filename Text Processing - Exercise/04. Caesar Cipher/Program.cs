using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string word = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                word += (char)((int)input[i] + 3);
            }
            Console.WriteLine(word);
        }
    }
}
