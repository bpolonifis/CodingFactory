using System.Numerics;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            BigInteger result = 1;
            int i = 1;

            while (i <=  n) 
            {
                result = result * i;
                //result *= i;
                i++;
            }
            Console.WriteLine($"1*....* {n}= {result}");

        }
    }
}