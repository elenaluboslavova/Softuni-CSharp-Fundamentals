using System;
using System.ComponentModel;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string vowels = "aAeEiIoOuU";
            char[] vowelsArray = vowels.ToCharArray();
            string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";
            char[] consonantsArray = consonants.ToCharArray();

            int sum = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    if (vowelsArray.Contains(name[j]))
                    {
                        sum += (int)(name[j]) * name.Length;
                    }
                    else
                    {
                        sum += (int)(name[j]) / name.Length;
                    }
                    
                }
                numbers[i] = sum;
                
                
            }
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.Write(item);
                Console.WriteLine();
            }

        }
    }
}
