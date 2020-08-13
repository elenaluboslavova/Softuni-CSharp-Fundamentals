using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> furniture = new List<string>();

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            double totalPrice = 0;

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    totalPrice += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }



            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
