using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();
            
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input.Split().ToList();
                int index = int.Parse(command[1]);
                if (command[0] == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        int power = int.Parse(command[2]);
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }

                else if (command[0] == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        int value = int.Parse(command[2]);
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (command[0] == "Strike")
                {
                    bool isMissed = false;
                    int radius = int.Parse(command[2]);
                    newList.AddRange(targets);
                    

                    for (int i = index + radius; i >= index; i--)
                    {
                        if (i < 0 || i >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            isMissed = true;
                            break;
                        }
                        else
                        {
                            newList.RemoveAt(i);
                        }
                    }
                    for (int i = index - 1; i >= index - radius; i--)
                    {
                        if (isMissed)
                        {
                            break;
                        }
                        if (i < 0 || i >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            isMissed = true;
                            break;
                        }
                        else
                        {
                            newList.RemoveAt(i);
                        }
                    }
                    if (!isMissed)
                    {
                        targets = newList;
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
