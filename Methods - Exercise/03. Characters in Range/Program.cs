using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            PrintChars(ch1, ch2);
        }

        static void PrintChars(char ch1,char ch2)
        {
            int n1 = (int)ch1 + 1;
            int n2 = (int)ch2 + 1;
            char number1 = (char)n1;
            char number2 = (char)n2;

            if ((int)ch1 < (int)ch2)
            {

                for (char i = number1; i < ch2; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = number2; i < ch1; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
