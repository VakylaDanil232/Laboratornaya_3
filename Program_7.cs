﻿using System;
namespace laba3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер члена n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n-ый член ряда Фибоначчи: " + Fibonacci(n));
            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}