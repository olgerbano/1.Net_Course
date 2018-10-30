using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator6_Suport
{
    public enum AccountType { Cec, Deposit }
    /*
    public struct BankAccount
    {
        public AccountType accType;
        public long accNumber;
        public int amount;
    }
    */
    /*
    public class BankAccount
    {
        public AccountType accType;
        public long accNumber;
        public int amount;
    }
    */
    class BankAccount
    {
        public void Populate(decimal dob, AccountType tip)
        {
            //accNumber = nr;
            accNumber = NextNumber();
            amount = dob;
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
        public bool WithDraw(decimal amount)
        {
            if (amount > this.amount)
                return false;
            this.amount -= amount;
            return true;
        }
        public decimal Deposit(decimal amount)
        {
            this.amount += amount;
            return this.amount;
        }
        public static void TestDeposit(BankAccount acc)
        {
            Console.WriteLine("Introdu suma ");
            decimal suma = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Suma noua este: " + acc.Deposit(suma));
        }
        public static void TestWithdraw(BankAccount acc)
        {
            Console.WriteLine("Introdu suma ");
            decimal suma = decimal.Parse(Console.ReadLine());
            if (acc.WithDraw(suma))
                Console.WriteLine("Suma noua este" + acc.Amount());
            else
                Console.WriteLine("Suma este prea mare ");

        }
        private AccountType accType;
        private long accNumber;
        private decimal amount;
        private static long succNrCont = 123;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            long nr;
            nr = BankAccount.NextNumber();
            // account.accType = AccountType.Deposit;
            //account.amount = 10;

            //Console.WriteLine("Introduceti numarul de cont: ");
            //account.accNumber = long.Parse(Console.ReadLine());
            account.Populate(10M, AccountType.Cec);
            Console.WriteLine("Contul meu are numarul {0}, este de tip {1} si are o suma de {2}",
                account.AccNumber(), account.ReturnType(), account.Amount());
            BankAccount.TestDeposit(account);
            BankAccount.TestWithdraw(account);
            Console.ReadKey();
        }
    }
}
