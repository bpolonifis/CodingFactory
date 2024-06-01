using System.Text;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[])
        {
           // var sb = new StringBuilder();
           StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            Console.WriteLine(DateTime.Now);
            for (int i = 1;i<= 5_000_000;i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(sb.ToString().Substring(0,100));


        }
    }
}