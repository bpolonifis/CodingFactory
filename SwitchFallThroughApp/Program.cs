namespace SwitchFallThroughApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;

            Console.WriteLine("Please insert grade");
            grade=int.Parse(Console.ReadLine()!);

            switch (grade)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Fall");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Pass");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Very Well");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine();
                    break;


            }

        }
    }
}