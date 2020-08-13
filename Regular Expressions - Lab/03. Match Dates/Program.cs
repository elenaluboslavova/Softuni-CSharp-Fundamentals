using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex datesRegex = new Regex(@"[0-9]{2}(.)[A-Za-z]{3}\1\d{4}");
            MatchCollection dates = Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Za-z]{3})\k<separator>(\d{4})");

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups[1]}");
            }
        }
    }
}
