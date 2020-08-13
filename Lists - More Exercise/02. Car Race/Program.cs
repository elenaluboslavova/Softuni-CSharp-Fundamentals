using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            double firstTime = 0;
            double secondTime = 0;

            for (int i = 0; i < list.Count / 2; i++)
            {
                if (list[i] == 0)
                {
                    firstTime *= 0.8;
                }
                else
                {
                    firstTime += list[i];
                }
            }
            for (int i = list.Count -1; i > list.Count / 2; i--)
            {
                if (list[i] == 0)
                {
                    secondTime *= 0.8;
                }
                else
                {
                    secondTime += list[i];
                }
            }

            if (secondTime > firstTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondTime}");
            }
        }
    }
}
