using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string model = "";
            double radius = 0;
            int height = 0;
            double volume = 0;

            double maxVolume = double.MinValue;
            string maxModel = "";

            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume >= maxVolume)
                {
                    maxVolume = volume;
                    maxModel = model;
                }

            }
            Console.WriteLine(maxModel);
        }
    }
}
