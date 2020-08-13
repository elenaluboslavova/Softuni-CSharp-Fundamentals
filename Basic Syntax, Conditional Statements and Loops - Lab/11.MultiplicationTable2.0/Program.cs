using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (k>10)
            {
                Console.WriteLine($"{n} X {k} = {n*k}");
                Environment.Exit(0);
            }
            for (int i = k; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
