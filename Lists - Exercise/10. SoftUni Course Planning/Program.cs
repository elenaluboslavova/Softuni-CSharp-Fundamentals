using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            string command = string.Empty;
            string action = string.Empty;
            string element = string.Empty;
            string lesson = string.Empty;
            int index = 0;
            string element1 = string.Empty;
            string firstLesson = string.Empty;
            string secondLesson = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "course start")
                {
                    break;
                }

                List<string> incomingDetails = command.Split(":").ToList();

                for (int i = 0; i < incomingDetails.Count; i++)
                {
                    action = incomingDetails[0];
                    element = incomingDetails[1];

                    if (action == "Insert")
                    {
                        index = int.Parse(incomingDetails[2]);
                        lesson = element;
                        break;
                    }
                    else if (action == "Swap")
                    {
                        string elementInsert = incomingDetails[2];
                        firstLesson = incomingDetails[1];
                        secondLesson = incomingDetails[2];
                        break;
                    }
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (action == "Add")
                    {
                        if (!input.Contains(element))
                        {
                            input.Add(element);
                        }
                    }
                    else if (action == "Remove")
                    {
                        string exercise = element + '-' + "Exercise";
                        if (input.Contains(element))
                        {
                            input.Remove(element);
                        }
                        if (input.Contains(exercise))
                        {
                            input.Remove(exercise);
                        }
                    }
                    else if (action == "Exercise")
                    {
                        string exercise = element + '-' + "Exercise";
                        if (!input.Contains(element))
                        {
                            if (!input.Contains(exercise))
                            {
                                input.Add(element);
                                input.Add(exercise);
                                break;
                            }
                            break;
                        }
                        else if (input.Contains(element) && !input.Contains(exercise))
                        {
                            int indexx = input.IndexOf(element);
                            input.Insert(indexx + 1, exercise);
                            break;
                        }
                    }
                    else if (action == "Insert")
                    {
                        if (!input.Contains(lesson))
                        {
                            input.Insert(index, lesson);
                            break;
                        }
                        break;
                    }
                    else if (action == "Swap")
                    {
                        if (input.Contains(firstLesson) && input.Contains(secondLesson))
                        {
                            string exercise = firstLesson + '-' + "Exercise";
                            int index1 = input.IndexOf(firstLesson);
                            int index2 = input.IndexOf(secondLesson);
                            string temp = firstLesson;
                            input.RemoveAt(index1);
                            input.Insert(index1, secondLesson);

                            if (input.Contains(exercise))
                            {
                                input.Remove(exercise);
                                input.Insert(index1 + 1, exercise);
                            }

                            exercise = string.Empty;
                            exercise = secondLesson + '-' + "Exercise";
                            input.RemoveAt(index2);
                            input.Insert(index2, temp);

                            if (input.Contains(exercise))
                            {
                                input.Remove(exercise);
                                input.Insert(index1 + 1, exercise);
                            }
                        }
                        break;
                    }
                }
                
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
