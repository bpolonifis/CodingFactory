using System;


namespace ArgsApp

{
    /// <summary>
    /// Ctrl+ view>terminal
    /// write cd foldername
    /// write csc pr +tab
    /// Elegxei an oi metavlites poy pernane sto programma einai 3 oser orizei to args[]
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Error");
                Environment.Exit(1);

            }
            Console.WriteLine($"args(0): {args[0]}, args(1): {args[1]}, args(2): {args[2]}");
        }
    }
}