﻿namespace FiboApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine(Fibonacci(n));
            for (int i = 0; i <= n; i++)
            {
                Console.Write(Fibonacci(i) +" ");
            }

        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}