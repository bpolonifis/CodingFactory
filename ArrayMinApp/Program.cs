namespace ArrayMinApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 56, 34, 8, 95, 21 };

            int minPosition = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[minPosition])
                {
                    minPosition = i;
                }

            }

            Console.WriteLine($"Min price: {prices[minPosition]} in position {minPosition + 1}");

        }
    }
}