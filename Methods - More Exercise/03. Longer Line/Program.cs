using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, a1, b1, a2, b2);
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
            if ((Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2)) < (Math.Abs(a1) + Math.Abs(b1) + Math.Abs(a2) + Math.Abs(b2)))
            {
                if ((Math.Abs(a1) + Math.Abs(b1)) > (Math.Abs(a2) + Math.Abs(b2)))
                {
                    Console.WriteLine($"({a2}, {b2})({a1}, {b1})");
                }
                else
                {
                    Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
                }
            }
            else
            {
                if ((Math.Abs(x1) + Math.Abs(y1)) > (Math.Abs(x2) + Math.Abs(y2)))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
        }
    }
}
