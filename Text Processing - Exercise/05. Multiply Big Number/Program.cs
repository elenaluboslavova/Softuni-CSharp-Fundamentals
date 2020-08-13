using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNumber = Console.ReadLine().TrimStart('0');
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }


            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = reallyBigNumber.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(reallyBigNumber[i].ToString()) * number + remainder;
                remainder = 0;

                if (result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }

            if(remainder != 0)
            {
                sb.Append(remainder);
            }


            StringBuilder finalResult = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0 ; i--)
            {
                finalResult.Append(sb[i]);
            }
            Console.WriteLine(finalResult);
        }
    }
}
