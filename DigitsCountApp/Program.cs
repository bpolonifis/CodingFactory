namespace DigitsCountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 123;
            int result = num;
            int count = 0;

            do
            {
                result /= 10;
                count++;

            } while (result != 0);
            Console.WriteLine($"Digits count = {count}");
        }
    }
}