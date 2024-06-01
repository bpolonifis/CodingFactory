namespace NullableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null; //nullable me erwtimatiko
            Console.WriteLine("i = {0}", (i == null) ? "null": "not null");
        }
    }
}