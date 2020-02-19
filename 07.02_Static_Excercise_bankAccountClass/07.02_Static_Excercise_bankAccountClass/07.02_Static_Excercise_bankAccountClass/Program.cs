using System;

namespace _07._02_Static_Excercise_bankAccountClass
{
    class BankAccount
    {
        private decimal Amount;  // Pro finance vetsinou decimal
        public static decimal InterestRate = 2;

        public BankAccount(int amount)
        {
            this.Amount = amount;
        }

        public void AddInterest()
        {
            this.Amount = this.Amount * (BankAccount.InterestRate / 100) + this.Amount;
        }

        public string GetInfo()
        {
            return $"Amount: {this.Amount}, Interest rate: {BankAccount.InterestRate}.";
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            BankAccount fio = new BankAccount(10000);
            BankAccount mBank = new BankAccount(2000);

            Console.WriteLine("Fio: {0}", fio.GetInfo());
            Console.WriteLine("MBank: {0}", mBank.GetInfo());

            fio.AddInterest();
            fio.AddInterest();
            fio.AddInterest();
            fio.AddInterest();
            mBank.AddInterest();

            Console.WriteLine("After interest");

            Console.WriteLine("Fio: {0}", fio.GetInfo());
            Console.WriteLine("MBank: {0}", mBank.GetInfo());

        }
    }
}