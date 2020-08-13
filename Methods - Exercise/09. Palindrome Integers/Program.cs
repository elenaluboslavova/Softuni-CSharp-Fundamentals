using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            while (number != "END")
            {
                CheckIfPalindrome(number);
                number = Console.ReadLine();
            }
            
        }

        static void CheckIfPalindrome(string number)
        {
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            if (reversed == number)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
