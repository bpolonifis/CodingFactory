using LinqApp.Students;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new() { new() { Id = 1, Firstname = "Alice", Lastname = "Wonder" },
            new() { Id = 2, Firstname = "Bob", Lastname = "Wonder" },
            new() { Id = 3, Firstname = "Chris", Lastname = "Adroutsos" },
             new() { Id = 4, Firstname = "Nick", Lastname = "Adroutsos" }
            };

            var studentsByLastname = from student in students
                                     group student by student.Lastname into studentGroup
                                     orderby studentGroup.Key
                                     select studentGroup;

            foreach (var studentGroup in studentsByLastname)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup) 
                {
                    Console.WriteLine($"\t{student.Firstname}");
                }
            }



            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<int> evenLists = 
                (from num in numbers
                 where(num%2) == 0
                 orderby num ascending
                select num).ToList();

            evenLists.ForEach(num => Console.Write(num+ " "));

            Console.WriteLine();    

            var evensArr =
                (from num in numbers
                 where (num % 2) == 0
                 orderby num descending
                 select num).ToArray();
            
            foreach (var num in evensArr)
            {
                Console.Write(num + " ");
            }
*/


            /* // 1.Get Datasource
             int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };


             // IEnumerable<int>
             // 2. Create Query
             var allNumbers = from num in numbers
                              select num;
             //3. Execute Query
             foreach (int num in allNumbers)
             {
                 Console.WriteLine(num + " ");
             }

             // 2. Create Query
             var oddNumbers = from num in numbers
                              where num%2 !=0
                              select num;


             //3. Execute Query
             foreach (int num in oddNumbers)
             {
                 Console.WriteLine(num + " ");
             }*/
        }
    }
}
