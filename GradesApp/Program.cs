namespace GradesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesSum;
            int gradesCount;
            int average;

            Console.WriteLine("Please insert grades sum");
            if (!int.TryParse(Console.ReadLine(), out gradesSum))
            {
                Console.WriteLine("Error in grades sum input");

            }

            Console.WriteLine("Please insert grades count");
            if (!int.TryParse(Console.ReadLine(), out gradesCount))
            {
                Console.WriteLine("Error in grades count input");
            }
            if (gradesCount == 0)
            {
                Console.WriteLine($"Error  - Grades count is {gradesCount}");
            }
            average = gradesSum / gradesCount;

            Console.WriteLine($"average:{average}");
            if (average > 10 )
            {
                Console.WriteLine($"Average is invalid:{average}");
            }
            else if (average >= 8)
            {
                Console.WriteLine("Exellent");
            }
            else if (average > 6)
            {
                Console.WriteLine("Very good");
            }
            else if (average > 5)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}