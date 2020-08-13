using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers1 = new int[n];
            int[] numbers2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split();
                int num1 = int.Parse(nums[0]);
                int num2 = int.Parse(nums[1]);

                if (i % 2 == 0)
                {
                    numbers1[i] = num1;
                    numbers2[i] = num2;
                }
                else
                {
                    numbers1[i] = num2;
                    numbers2[i] = num1;
                }
            }
            Console.WriteLine(String.Join(' ', numbers1));
            Console.WriteLine(String.Join(' ', numbers2));
        }
    }
}
