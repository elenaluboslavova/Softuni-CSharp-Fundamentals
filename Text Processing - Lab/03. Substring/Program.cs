using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            while (word2.Contains(word))
            {

                word2 = word2.Remove(word2.IndexOf(word), word.Length);
            }
            Console.WriteLine(word2);
        }
    }
}
