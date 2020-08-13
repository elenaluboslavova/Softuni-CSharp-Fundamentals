using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                string pattern = @"@#+(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(barcode);
                string sum = string.Empty;
                int count = 0;
                if (match.Success)
                {
                    for (int j = 0; j < barcode.Length - 1; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            sum += barcode[j];
                            count = 1;
                        }
                        
                    }
                    if (count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: { sum}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
