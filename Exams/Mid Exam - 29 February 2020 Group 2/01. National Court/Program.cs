using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEfficiency = int.Parse(Console.ReadLine());
            int secondEfficiency = int.Parse(Console.ReadLine());
            int thirdEfficiency = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int allEfficiency = firstEfficiency + secondEfficiency + thirdEfficiency;
            int answeredPeople = 0;
            int hours = 0;
            bool isBreak = false;

            while (answeredPeople < peopleCount)
            {
                for (int i = 0; i < 3; i++)
                {
                    isBreak = false;
                    answeredPeople += allEfficiency;
                    hours++;
                    if (answeredPeople >= peopleCount)
                    {
                        isBreak = true;
                        break;
                    }
                }
                if (!isBreak)
                {
                    hours++;
                }
                

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
