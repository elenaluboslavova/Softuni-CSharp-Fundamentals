﻿using System;

namespace _2._First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number >> 1) & 1);
        }
    }
}
