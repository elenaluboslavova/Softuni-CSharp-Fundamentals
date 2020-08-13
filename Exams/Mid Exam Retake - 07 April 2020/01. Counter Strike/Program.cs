using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int wonsCounter = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                if (initialEnergy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonsCounter} won battles and {initialEnergy} energy");
                    Environment.Exit(0);
                }
                initialEnergy -= distance;
                wonsCounter++;
                if (wonsCounter % 3 == 0)
                {
                    initialEnergy += wonsCounter;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {wonsCounter}. Energy left: {initialEnergy}");
        }
    }
}
