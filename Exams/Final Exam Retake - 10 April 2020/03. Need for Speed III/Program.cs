using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictMileage = new Dictionary<string, int>();
            var dictFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                dictMileage.Add(carName, mileage);
                dictFuel.Add(carName, fuel);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                string[] inputArray = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = inputArray[0];
                string car = inputArray[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(inputArray[2]);
                    int fuel = int.Parse(inputArray[3]);

                    if (dictFuel[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        dictFuel[car] -= fuel;
                        dictMileage[car] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (dictMileage[car] >= 100000)
                        {
                            dictMileage.Remove(car);
                            dictFuel.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }

                else if (command == "Refuel")
                {
                    int fuel = int.Parse(inputArray[2]);
                    dictFuel[car] += fuel;
                    if (dictFuel[car] > 75)
                    {
                        Console.WriteLine($"{car} refueled with {dictFuel[car] - 75} liters");
                        dictFuel[car] = 75;
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }

                else if (command == "Revert")
                {
                    int kilometers = int.Parse(inputArray[2]);
                    dictMileage[car] -= kilometers;
                    if (dictMileage[car] < 10000)
                    {
                        dictMileage[car] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var pair in dictMileage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> Mileage: {pair.Value} kms, Fuel in the tank: {dictFuel[pair.Key]} lt.");
            }
        }
    }
}
