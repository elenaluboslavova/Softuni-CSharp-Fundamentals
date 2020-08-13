using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (day == "Friday")
            {
                switch (groupType)
                {
                    case "Students":
                        sum = people * 8.45;
                        break;
                    case "Business":
                        sum = people * 10.90;
                        if (people >= 100)
                        {
                            sum = sum - 10 * 10.90;
                        }
                        break;
                    case "Regular":
                        sum = people * 15;
                        break;
                }
            }

            else if (day == "Saturday")
            {
                switch (groupType)
                {
                    case "Students":
                        sum = people * 9.80;
                        break;
                    case "Business":
                        sum = people * 15.60;
                        if (people >= 100)
                        {
                            sum = sum - 10 * 15.60;
                        }
                        break;
                    case "Regular":
                        sum = people * 20;
                        break;
                }
            }

            else if (day == "Sunday")
            {
                switch (groupType)
                {
                    case "Students":
                        sum = people * 10.46;
                        break;
                    case "Business":
                        sum = people * 16;
                        if (people >= 100)
                        {
                            sum = sum - 10 * 16;
                        }
                        break;
                    case "Regular":
                        sum = people * 22.50;
                        break;
                }
            }

            if (groupType == "Students" && people >= 30)
            {
                sum = sum - sum * 0.15;
            }
            if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                sum = sum - sum * 0.05;
            }

            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
