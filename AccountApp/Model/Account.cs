using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AccountApp.Exceptions;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        /// <summary>
        /// Deposits an amoun of money to <see cref="Account"/>.
        /// </summary>
        /// <param name="amount">The amount of money to be deposited.</param>


        public void Deposit(Decimal amount)
        {
            try
            { 
                if (amount < 0) throw new NegativeAmountException("Negative amount");
                Balance += amount;
             } catch (NegativeAmountException e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public void Withdraw(decimal amount, string ssn)
        {
            try { 
            if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException("Empty or null String Error");
            if (!IsSsnValid(ssn)) throw new InvalidSsnException("Ssn: " + ssn + "in not valid");
            if (amount < 0) throw new NegativeAmountException("Negative amount" + amount + "is not permitted");
            Balance -= amount;
            }
            /* enallaktiko catch alla den pianei ta ypoloipa lathi. Kalo gia ypoperiptwseis.
             * catch (Exception e) when (e is NegativeAmountException || e is InvalidSsnException) 
            {
                Console.Error.WriteLine( e.Message);
                throw;
            }*/
            catch (InvalidSsnException e)//e proairetiko
            {
                Console.Error.WriteLine("Error invalid ssn exception" + e.Message); //e.Message proairetiko
                throw;
            }
            catch (NegativeAmountException e)
            {
                Console.Error.WriteLine("Error negative amount: " + e.Message);
                throw;
            }

        }
        /// <summary>
        /// Gets the balance of the <see cref="Account "/>.
        /// </summary>
        /// <returns>The  balance. </returns>

        public decimal GetBalance()
        {
            return Balance; 
        }
    
            
        private bool IsSsnValid(string ssn)
        {
            return string.Equals(Ssn, ssn);
        }

        public override string? ToString()
        {
            return $"Id={Id}, Iban={Iban}, Firstname={Firstname}, Lastname={Lastname}, Ssn={Ssn}, Balance={Balance}";
        }
    }
}
