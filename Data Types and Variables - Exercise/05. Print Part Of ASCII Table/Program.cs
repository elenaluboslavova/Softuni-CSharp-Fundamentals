using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }
}
