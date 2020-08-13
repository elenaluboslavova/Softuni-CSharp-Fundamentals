using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int jumpIndex = 0;
            int lastPosition = 0;
            int counter = 0;
            bool already = false;

            while (input != "Love!")
            {
                already = false;
                string[] command = input.Split();

                int index = int.Parse(command[1]);
                jumpIndex += index;
                
                if (jumpIndex < 0 || jumpIndex >= houses.Count)
                {
                    jumpIndex = 0;
                }
                int current = houses[jumpIndex];
                current -= 2;
                if (houses[jumpIndex] == -10)
                {
                    Console.WriteLine($"Place {jumpIndex} already had Valentine's day.");
                    already = true;
                }
                if (current <= 0 && !already)
                {
                    Console.WriteLine($"Place {jumpIndex} has Valentine's day.");
                    counter++;
                    houses[jumpIndex] = -10;
                }
                lastPosition = jumpIndex;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (houses.Count == counter)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houses.Count - counter} places.");
            }
        }
    }
}
