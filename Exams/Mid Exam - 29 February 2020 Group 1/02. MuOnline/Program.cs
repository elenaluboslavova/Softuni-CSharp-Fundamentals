using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                string[] currentRoom = rooms[i].Split();
                string command = currentRoom[0];
                int num = int.Parse(currentRoom[1]);

                if (command == "potion")
                {
                    if (health + num > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += num;
                        Console.WriteLine($"You healed for {num} hp.");
                    }
                    
                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (command == "chest")
                {
                    bitcoins += num;
                    Console.WriteLine($"You found {num} bitcoins.");
                }

                else
                {
                    health -= num;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
