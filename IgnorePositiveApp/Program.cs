namespace IgnorePositiveApp
{
    /// <summary>
    /// Counts the negative numbers given by user, exit by pressing 0.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Please give numbers, exit by giving 0");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine(("Error in num"));
                Environment.Exit(1);
            }
            while(num != 0)
            {
                if (num < 0) count++;

                
                if (!int.TryParse(Console.ReadLine(), out  num))
                {
                    Console.WriteLine(("Error in num"));
                    Environment.Exit(1);
                    // break;
                }

            }
            Console.WriteLine($"Negatives count: {count}");

        }
    }
}