using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                capacity -= liters;

                if (capacity < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity += liters;
                    continue;
                }
            }
            Console.WriteLine(255-capacity);
        }
    }
}
