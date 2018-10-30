using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator7
{
    enum AccountType { Cec, Deposit }

    class BankAccount
    {
        public void Populate(decimal amount, AccountType tip)
        {
            accNumber = NextNumber();
            this.amount = amount;
            accType = tip;
        }

        public long AccNumber()
        {
            return accNumber;
        }

        public decimal Amount()
        {
            return amount;
        }

        public AccountType ReturnType()
        {
            return accType;
        }

        public static long NextNumber()
        {
            return succNrCont++;
        }

        public decimal Deposit(decimal amount)
        {
            this.amount += amount;
            return this.amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > this.amount)
                return false;

            this.amount -= amount;
            return true;
        }

        public static void TestDeposit(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o depuneti");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Noul sold este: {0}", cb.Deposit(amount));
        }

        public static void TestWithdraw(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o retrageti");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (cb.Withdraw(amount) == true)
                Console.WriteLine("Noul sold este: {0}", cb.Amount());
            else
                Console.WriteLine("Suma este prea mare");
        }

        public void TransferFrom(BankAccount sourceAccount, int amount)
        {
            // extragem suma din contul sursa
            if (sourceAccount.Withdraw(amount) == false)
            {
                Console.WriteLine("Suma ceruta nu exista in cont");
                return;
            }
            // adaugam suma in contul destinatie
            this.Deposit(amount);
        }

        private long accNumber;
        private decimal amount;
        private AccountType accType;
        private static long succNrCont = 123;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            long nr= BankAccount.NextNumber();

            account.Populate(50.8M, AccountType.Cec);

            Console.WriteLine("Informatii cont:\nnr {0}\ndobanda {1}\ntip {2}\n",
                account.AccNumber(), account.Amount(), account.ReturnType());

            BankAccount.TestDeposit(account);
            BankAccount.TestWithdraw(account);

            Console.ReadKey();
        }
    }
}
