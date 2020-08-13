using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] file = input[input.Length - 1].Split(".").ToArray();

            string name = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
