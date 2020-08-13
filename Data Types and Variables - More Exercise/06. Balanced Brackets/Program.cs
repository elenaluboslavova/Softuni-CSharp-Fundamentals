using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int deviationCounter = 0;
            bool isBalanced = true;

            int counterLeftBracket = 0;
            int counterRightBracket = 0;

            for (int i = 0; i < countOfLines; i++)
            {
                string currentSymbol = Console.ReadLine();

                bool isChar = char.TryParse(currentSymbol, out char chValue);
                if (chValue == '(')
                {
                    deviationCounter++;
                    counterLeftBracket++;
                    if (deviationCounter >= 2)
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (chValue == ')')
                {
                    deviationCounter--;
                    counterRightBracket++;
                    if (deviationCounter < 0)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            if (isBalanced && counterLeftBracket == counterRightBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
