using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Groups[0] + " ");
            }
        }
    }
}
