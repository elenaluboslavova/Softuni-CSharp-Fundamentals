using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    int first = list[0];
                    list.RemoveAt(0);
                    list.Insert(0, list[list.Count - 1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > first)
                        {
                            list[i] -= first;
                        }
                        else if (list[i] <= first)
                        {
                            list[i] += first;
                        }
                        
                    }
                    sum += first;
                    continue;
                }
                if (index >= list.Count)
                {
                    int last = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list.Add(list[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > last)
                        {
                            list[i] -= last;
                        }
                        else if (list[i] <= last)
                        {
                            list[i] += last;
                        }
                        
                    }
                    sum += last;
                    continue;
                }

                int number = list[index];
                list.RemoveAt(index);
                sum += number;
                
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > number)
                    {
                        list[i] -= number;
                    }
                    else if (list[i] <= number)
                    {
                        list[i] += number;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
