using System.Numerics;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BigInteger facto100 = Program.Facto(100); // Plheres onoma static methodwn
            BigInteger facto100 = Facto(100);
            Console.WriteLine($"{facto100:N0}");

        }

        public static BigInteger Facto(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}