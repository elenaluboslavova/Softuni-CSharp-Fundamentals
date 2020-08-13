using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        static void ValidatePassword(string password)
        {
            bool invalid = false;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (!IsNumOrLetter(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (CountDigits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (!invalid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static int CountDigits(string text)
        {
            int digitsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }

        static bool IsNumOrLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
