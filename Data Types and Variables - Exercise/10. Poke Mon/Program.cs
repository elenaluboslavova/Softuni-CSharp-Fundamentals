using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());

            int originalValue = N;
            int counter = 0;
            while (N >= M)
            {
                if (originalValue == 2 * N && Y > 0)
                {
                    N /= Y;
                    continue;
                }
                N -= M;
                counter++;
            }
            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
