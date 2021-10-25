using System;

namespace SampleApp
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name)
        {
            Number = accountNumberSeed.ToString(); // "1234567890"
            accountNumberSeed++;

            Balance = 50m;
            Owner = name;
    }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int balance = 0;
    //        BankAccount account1 = new BankAccount("John");
    //        BankAccount account2 = new BankAccount("Mary");


    //        Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance.");
    //        Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

    //    }
    //}
}