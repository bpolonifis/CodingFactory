namespace CharApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int ord;
            Console.WriteLine("Please insert chars");
            do
            {
                ord = Console.Read();
                Console.WriteLine($"char: {(char)ord},ordinal: {ord}");
            } while (ord != 10);

        }
    }
}