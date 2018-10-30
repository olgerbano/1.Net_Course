using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace SolutieLaborator11
{
    class Program
    {
        static void Main(string[] args)
        {
            long nrCont = Bank.CreateAccount();
            BankAccount account = Bank.GetAccount(nrCont);

            BankAccount.TestDeposit(account);
            BankAccount.TestWithdraw(account);
            BankAccount.Write(account);

            long nrCont2 = Bank.CreateAccount(AccountType.Deposit);
            BankAccount account2 = Bank.GetAccount(nrCont2);

            BankAccount.TestDeposit(account2);
            BankAccount.TestWithdraw(account2);
            BankAccount.Write(account2);

            long nrCont3 = Bank.CreateAccount(300M);
            BankAccount account3 = Bank.GetAccount(nrCont3);
            account.AuditTrail("fis1.txt");
            account2.AuditTrail("fis2.txt");
            account3.AuditTrail("fis3.txt");

            BankAccount.TestDeposit(account3);
            BankAccount.TestWithdraw(account3);
            BankAccount.Write(account3);

            long nrCont4 = Bank.CreateAccount(AccountType.Deposit, 300M);
            BankAccount account4 = Bank.GetAccount(nrCont4);
            account4.AuditTrail("fis4.txt");

            BankAccount.TestDeposit(account4);
            BankAccount.TestWithdraw(account4);
            BankAccount.Write(account4);


            //verificam inchiderea contului 1
            if (Bank.CloseAccount(nrCont) == true)
                Console.WriteLine("Contul a fost inchis");
            else
                Console.WriteLine("Nr de cont este invalid");

            Console.ReadKey();
        }
    }
}
