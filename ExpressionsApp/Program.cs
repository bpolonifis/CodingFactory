//using static System.Math;
using System;

namespace ExpressionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int sum, mul, div, mod, result1 = 0, result2 =0, result3;

            sum = num1 + num2;
            mul = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            result1 += sum;

            result1++; //result =4

            result3 = result2++;

            result2 = (result1 >= 4) ? 1 : 0;

            result3 = Math.Abs(result2);
        }
    }
}