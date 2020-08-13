using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> list = input.Split().ToList();

                string command = list[0];

                if (command == "swap")
                {
                    int index1 = int.Parse(list[1]);
                    int index2 = int.Parse(list[2]);

                    int temp = elements[index1];

                    elements[index1] = elements[index2];
                    elements[index2] = temp;
                }

                else if (command == "multiply")
                {
                    int index1 = int.Parse(list[1]);
                    int index2 = int.Parse(list[2]);

                    elements[index1] *= elements[index2];
                }

                else if (command == "decrease")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        elements[i]--;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
