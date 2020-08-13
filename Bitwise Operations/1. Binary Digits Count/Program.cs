using System;
using System.Collections.Generic;

namespace _1._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int count = 0;

            while (number != 0)
            {
                int reminder = number % 2;
                if (reminder == digit)
                {
                    count++;
                }
                number /= 2;
            }
            Console.WriteLine(count);
        }
    }
}
