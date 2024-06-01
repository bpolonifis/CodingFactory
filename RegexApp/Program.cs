using System.Text.RegularExpressions;

namespace RegexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expr;
            string[] tokens;
            int num1, num2;
            string op;
            int result =0;

            Console.WriteLine("Please insert the expression");
            expr = Console.ReadLine()!;

            tokens = Regex.Split(expr, @"\s+"); //@ kyriolektiko string
            num1 = int.Parse(tokens[0]);
            num2 = int.Parse(tokens[2]);
            op = tokens[1];

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 ==0)
                    {
                        Environment.Exit(1);
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operator Error");
                    break;


            }
            Console.WriteLine($"{result}");
        }
    }
}