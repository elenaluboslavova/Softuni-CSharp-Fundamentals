using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                List<string> list = command.Split(">>>").ToList();

                string action = list[0];

                if (action == "Contains")
                {
                    string substring = list[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (action == "Flip")
                {
                    int startIndex = int.Parse(list[2]);
                    int endIndex = int.Parse(list[3]);
                    if (list[1] == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (char.IsDigit(activationKey[i]))
                            {
                                endIndex++;
                                continue;
                            }


                            activationKey = activationKey.Replace(activationKey[i], char.ToUpper(activationKey[i]));

                        }
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (char.IsDigit(activationKey[i]))
                            {
                                endIndex++;
                                continue;
                            }

                            activationKey = activationKey.Replace(activationKey[i], char.ToLower(activationKey[i]));

                        }
                    }
                    Console.WriteLine(activationKey);
                }

                else if (action == "Slice")
                {
                    int startIndex = int.Parse(list[1]);
                    int endIndex = int.Parse(list[2]);
                    int counter = 0;

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        activationKey = activationKey.Remove(i, 1);
                        i--;
                        counter++;
                        if (counter == endIndex - startIndex)
                        {
                            break;
                        }
                    }
                    Console.WriteLine(activationKey);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
