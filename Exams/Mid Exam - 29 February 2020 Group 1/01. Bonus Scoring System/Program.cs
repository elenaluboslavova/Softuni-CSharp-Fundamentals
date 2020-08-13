using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            
            double maxBonus = 0;
            int maxAtendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int atendances = int.Parse(Console.ReadLine());
                
                double totalBonus = atendances * 1.0 / lecturesCount * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAtendances = atendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAtendances} lectures.");
        }
    }
}
