using System.Xml.Serialization;

namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {

                Console.WriteLine("Please insert choice");
                choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert");
                        break;
                    case 2:
                        Console.WriteLine("Update");
                        break;
                    case 3:
                        Console.WriteLine("Delete");
                        break;
                    case 4:
                        Console.WriteLine("Select");
                        break;
                    default:
                        Console.WriteLine("Error in choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}