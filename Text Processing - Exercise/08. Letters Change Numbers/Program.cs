using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];

                double number = double.Parse(text.Substring(1, text.Length - 2));

                text = text.Remove(1, text.Length - 2);

                char letterBefore = text[0];
                char letterAfter = text[1];

                int letterBeforePosition = (int)char.Parse(letterBefore.ToString().ToUpper()) - 64;
                int letterAfterPosition = (int)char.Parse(letterAfter.ToString().ToUpper()) - 64;

                if (letterBefore.ToString().ToLower() == letterBefore.ToString())
                {
                    number *= letterBeforePosition;
                }
                else
                {
                    number /= letterBeforePosition;
                }


                if (letterAfter.ToString().ToLower() == letterAfter.ToString())
                {
                    number += letterAfterPosition;
                }
                else
                {
                    number -= letterAfterPosition;
                }
                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
