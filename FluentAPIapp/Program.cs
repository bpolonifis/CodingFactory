namespace FluentAPIapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 ,4 ,5 ,6 ,7 };
            
            var allItems = numbers.Select(num => num);

            foreach (int num in allItems)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            var oddItems = numbers.Where(num => num % 2 != 0).Select(num => num);

            foreach (int num in oddItems)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            List<int> evens = numbers.Where(num => num % 2 ==0).Select(num => num).ToList();

            evens.ForEach(num => Console.Write(num + " "));

            Console.WriteLine();

            var evensArr= numbers.Where(num => num % 2 == 0).Select(num => num).ToArray();

            foreach (int num in evensArr)
            {
                Console.Write(num + " ");
            }

        }
    }
}
