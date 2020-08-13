using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Console.WriteLine(MultiplyStrings(array));
        }

        static int MultiplyStrings(string[] array)
        {
            string firstWord = array[0];
            string secondWord = array[1];

            int sum = 0;
            if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {

                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }
            else if (secondWord.Length > firstWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
            }

            return sum;
        }
    }
}
