namespace ReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Please insert two ints");

            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"num1 + num2 = {num1 + num2} ");
        }
    }
}