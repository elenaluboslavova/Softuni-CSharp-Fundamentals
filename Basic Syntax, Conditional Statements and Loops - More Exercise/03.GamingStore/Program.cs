using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double startingBalance = balance;
            string command = Console.ReadLine();
            double price = 0;

            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;

                }
                if (balance >= price)
                {
                    balance -= price;
                    Console.WriteLine($"Bought {command}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }




                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${startingBalance-balance:F2}. Remaining: ${balance:F2}");
        }
    }
}
