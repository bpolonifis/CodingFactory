namespace TypecastApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            long myLong = 100_000_000L;
            float myFloat = 19.75F;
            decimal myDecimal = 170_000M;
            
            num = (int) myLong;


            Console.WriteLine("{0:N0}",num);
            Console.WriteLine($"{num:N2}");
            Console.WriteLine("{0,20:N0}", num);
            Console.WriteLine("{0,-20:N0}", num);
        }
    }
}