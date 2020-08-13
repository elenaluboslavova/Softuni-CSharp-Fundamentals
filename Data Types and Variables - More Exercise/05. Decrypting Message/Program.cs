using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < lines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += (char)(letter + key);
            }
            Console.WriteLine(word);
        }
    }
}
