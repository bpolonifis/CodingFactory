using System.Threading.Channels;

namespace CollectionsApp
{
    internal class Program
    {
        /// <summary>
        /// Queues are FIFO
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>() {
                new Product { Description = "Milk", Price = 2M, Quantity = 50 },
                new Product { Description = "Apple", Price = 1.5M, Quantity = 100 },
                new Product { Description = "Oranges", Price = 1.8M, Quantity = 70 }
            };

            products.Sort();

            products.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();

            //ICompare<T>
            products.Sort((p1,p2) => p1.Quantity.CompareTo(p2.Quantity));
            products.ForEach(p => Console.WriteLine(p));



            // collection initializers
            /*var nims = new List<int> { 1, 2, 3, 4,5};
            var dict = new Dictionary<int, string> { { 1, "Alice" }, { 2, "Bob" } };*/




            /*
            *Set - No Duplicates
             */
            /* var s1  = new SortedSet<char>() { 'C','o','d','i','n','g','s' };
             var s2 = new SortedSet<char>() { 'F', 'a', 'c', 't', 'o', 'r', 'y' };
             s1.Remove('s');
             s1.Add('2');

             s1.ExceptWith(s2);
             foreach (char c in s1) Console.Write( c + " ");*/


            /* 
             * Stacks are LIFO
             */
            /*var stack  = new Stack<string>();
            stack.Push("Car.1");
            stack.Push("Car:2");
            stack.Push("Car:3");
            stack.Push("Car.4");
            stack.Push("Car:5");
            stack.Push("Car:6");
            var elem = stack.Peek();
            var val = stack.Pop();

            foreach (string el in stack)
            {
                Console.WriteLine(el  + " ") ;
            }*/



            /*
             var queue = new Queue<string>();
             queue.Enqueue("Car: 1");
             queue.Enqueue("Car: 2");
             queue.Enqueue("Car: 3");
             var topValue = queue.Peek();
             Console.WriteLine("Front el: " + topValue);
             var topItem = queue.Dequeue();
             Console.WriteLine(topItem);

             foreach (string el in queue)
             {
                 Console.WriteLine( el + " ");
             }*/




            /*
            var words = new SortedDictionary< int, string>();

            words.Add(1, "Hello");
            words.Add(2, "AUEB");
            words[2] = "Coding";
            words.Add(3, "Hello2");
            words.Remove(3);

            if (words.ContainsKey(2))
            {
                words.Add(3, "Factory");
            }
            foreach (var keyValue in words) 
            {
                Console.WriteLine(keyValue + " ");
            }
            foreach (var keyValue in words)
            {
                Console.WriteLine(keyValue.Value + " ");
            }
            */

            /*
            var lst = new LinkedList<string>();
            var elem1 = lst.AddFirst("Coding");
            var elem2 = lst.AddBefore(elem1,"Hello");
            var elem3 = lst.AddAfter(elem1,"Hello");
            var elem4 = lst.AddLast("AUEB");

            // Navigation to list
            lst.Last!.Previous!.Previous!.Value = "Coding";
            lst.First!.Next!.Next!.Value = "Factory";

            foreach( var elem in lst )
            {
                Console.WriteLine( elem + "");
            }*/







            /*
            var lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.AddRange(new[] {1,2,3,4,5 });
            lst.Insert(index:0, item: 2);
            lst[0] = 77;
            lst.RemoveAt(index:4);
            lst.Remove(item: 2);
            lst.RemoveRange(index:2, count:3);
            lst.Reverse();
            lst.Sort();
            bool isTwoExists = lst.Contains(2);
            int secondListItem = lst[2];
            */
        }
    }
}
