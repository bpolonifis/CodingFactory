namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] cities;
            string[] cities = new string[] { "London", "Paris", "Athens","Berlin"};
            // string[] cities = new string[] { "", "", "" };

            for (int i = 0; i < cities.Length; i++) 
            {
                Console.WriteLine(cities[i] + " ");
            }

            foreach (string city in cities)
            {
                Console.WriteLine(city+ " ");
            }

        }

    }
}