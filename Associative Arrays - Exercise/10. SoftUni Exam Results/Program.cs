using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] data = input.Split("-");
                string name = data[0];

                if (data[1] != "banned")
                {
                    if (points.ContainsKey(name) == false)
                    {
                        points.Add(name, 0);
                    }
                    int currentPoints = int.Parse(data[2]);

                    if (points[name] < currentPoints)
                    {
                        points[name] = currentPoints;
                    }

                    string language = data[1];

                    if (submissions.ContainsKey(language) == false)
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }

                else
                {
                    if (points.ContainsKey(name))
                    {
                        points.Remove(name);
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach(var participant in points.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{participant.Key} | {participant.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach(var language in submissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
