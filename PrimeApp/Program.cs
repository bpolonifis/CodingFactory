namespace PrimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            Console.WriteLine($"{n} is prime: {IsPrime(n)}");
        }

        public static bool IsPrime (int n)
        {
            bool isPrime = true;
            //if (n == 0) { return  isPrime=false; }

            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
       

            while (isPrime && divider <= maxDivider)
            {
                if (n % divider == 0)
                {
                    isPrime = false;
                }
                divider++;
            }
            return isPrime;


        }
        
    }
}