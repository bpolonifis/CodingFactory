using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Account alice = new()
            {
                Id = 1,
            Iban = "GR1235456",
            Firstname = "Alice",
            Lastname = "W.",
            Ssn = "123456",

            };

            try
            {
                alice.Deposit(1005.5M);
                Console.WriteLine(alice);

                alice.Withdraw(500, "123456");
                Console.WriteLine(alice);

                Console.WriteLine(alice.GetBalance());


            } catch (NegativeAmountException e)
            {
                Console.WriteLine(e.Message);
            } catch (InvalidSsnException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}