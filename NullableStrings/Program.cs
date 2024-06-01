namespace NullableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string? s2;

            s1 = Console.ReadLine()!;
            s2 = Console.ReadLine();

            if (s1 == ("AUEB") && (s2!=("AUEB")))
            {
            
                Console.WriteLine("AUEB");
            }
        }

        public static string GetUpperString ()
        {
            string? s1;

            Console.WriteLine("Please insert a string");
            s1 = Console.ReadLine();

            return s1?.ToUpper();
        }
    }
}