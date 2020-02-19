using System;

namespace _07._02_Static_Excercise_bankAccountClass
{
    class BankAccount
    {
        private double Amount;
        public static double InterestRate = 2;

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
            BankAccount Fio = new BankAccount(10000);
            BankAccount MBank = new BankAccount(2000);

            Console.WriteLine("Fio: {0}", Fio.GetInfo());
            Console.WriteLine("MBank: {0}", MBank.GetInfo());

            Fio.AddInterest();
            MBank.AddInterest();

            Console.WriteLine("After interest");

            Console.WriteLine("Fio: {0}", Fio.GetInfo());
            Console.WriteLine("MBank: {0}", MBank.GetInfo());

        }
    }
}