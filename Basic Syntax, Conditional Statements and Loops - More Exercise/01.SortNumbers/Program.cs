using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int m1 = 0;
            int m2 = 0;
            int m3 = 0;

            if (n1 >= n2 && n1>= n3)
            {
                m1 = n1;
                if (n2 >= n3)
                {
                    m2 = n2;
                    m3 = n3;
                }
                else
                {
                    m3 = n2;
                    m2 = n3;
                }
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                m1 = n2;
                if (n1 >= n3)
                {
                    m2 = n1;
                    m3 = n3;
                }
                else
                {
                    m3 = n1;
                    m2 = n3;
                }
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                m1 = n3;
                if (n1 >= n2)
                {
                    m2 = n1;
                    m3 = n2;
                }
                else
                {
                    m3 = n1;
                    m2 = n2;
                }
            }
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
        }
    }
}
