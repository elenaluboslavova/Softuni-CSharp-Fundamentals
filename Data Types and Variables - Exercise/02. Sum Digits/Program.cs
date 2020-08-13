using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int n1 = number;

            do
            {
                sum += n1 % 10;
                n1 = n1 / 10;
            }
            while (n1 > 0);
            Console.WriteLine(sum);
        }
    }
}
