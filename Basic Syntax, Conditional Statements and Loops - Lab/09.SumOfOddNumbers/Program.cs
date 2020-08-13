using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int k = 0;
            int a = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i+k);
                k++;
                a = i + k;
                sum += a;
            }
            Console.WriteLine($"Sum: {sum-n}");
        }
    }
}
