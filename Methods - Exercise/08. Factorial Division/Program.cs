using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideFactorials(n1, n2):F2}");
        }

        static double CalculateFirstF(double n1)
        {
            double sum = 1;
            if (n1 != 1)
            {
                for (double i = n1; i > 0; i--)
                {
                    sum *= i;
                }
            }
            
            return sum;
        }
        static double CalculateSecondF(double n2)
        {
            double sum = 1;
            if (n2 != 1)
            {
                for (double i = n2; i > 0; i--)
                {
                    sum *= i;
                }
            }
            
            return sum;
        }

        static double DivideFactorials(double n1, double n2)
        {
            double num = CalculateFirstF(n1) / CalculateSecondF(n2);
            return num;
        }
    }
}
