using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int counter = 0;
            while (command != "End")
            {
                int index = int.Parse(command);
                if (index < 0 || index >= targets.Count)
                {
                    command = Console.ReadLine();
                    continue;
                }
                int currentTarget = targets[index];
                
                targets.RemoveAt(index);
                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > currentTarget)
                    {
                        targets[i] -= currentTarget;
                    }
                    else
                    {
                        targets[i] += currentTarget;
                    }
                }
                counter++;
                currentTarget = -1;
                targets.Insert(index, currentTarget);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}
