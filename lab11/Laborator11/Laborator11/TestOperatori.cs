using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator11
{
    class TestOperatori
    {
        public static void Main()
        {
            long accNumber1 = Bank.CreateAccount(AccountType.Cec, 100M);
            long accNumber2 = Bank.CreateAccount(AccountType.Cec, 100M);
            BankAccount account1 = Bank.GetAccount(accNumber1);
            BankAccount account2 = Bank.GetAccount(accNumber2);

            // Folosim == si !=
            //Console.WriteLine("Conturile sunt egale:{0}",account1 == account2);
            //Console.WriteLine("Conturile nu sunt egale:{0}",account1 != account2);

            // Se foloseste implicit ToString de catre metoda Console.WriteLine
            Console.WriteLine(account1);
            Console.WriteLine(account2);

            // Folosim Equals
            Console.WriteLine("Conturile sunt egale:{0}", account1.Equals(account2));
            Console.WriteLine("Conturile nu sunt egale:{0}", !account1.Equals(account2));
            Console.ReadKey();
        }
    }

}