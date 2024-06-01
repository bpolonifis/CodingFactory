using ClassesApp.Model;

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();     //C# 9.0
            var chris = new Student();

           // Student student = new Student() { Id = 4, Firstname = "Alice", Lastname = "W." };
            Student student = new() { Id = 4, Firstname = "Alice", Lastname = "W." }; //object initializer den mporei an exeis private set
                                                                                      // tote vazeis init anti gia private
            Console.WriteLine(student.Firstname + "," + student.Lastname);
            student.Lastname = "Wonderland";
            Console.Write(student.Lastname);

        }
    }
}