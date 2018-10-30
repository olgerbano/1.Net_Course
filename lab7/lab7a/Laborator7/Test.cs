using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator7
{
    class Test
    {
        static void Main()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.Populate(100M, AccountType.Deposit);
            account2.Populate(100M, AccountType.Deposit);

            Console.WriteLine("Contul este de tip {0}, are numarul {1} si suma {2}", account1.ReturnType(), account1.AccNumber(), account1.Amount());
            Console.WriteLine("Contul este de tip {0}, are numarul {1} si suma {2}", account2.ReturnType(), account2.AccNumber(), account2.Amount());

            account1.TransferFrom(account2, 10);
            Console.WriteLine("Contul este de tip {0}, are numarul {1} si suma {2}", account1.ReturnType(), account1.AccNumber(), account1.Amount());
            Console.WriteLine("Contul este de tip {0}, are numarul {1} si suma {2}", account2.ReturnType(), account2.AccNumber(), account2.Amount());

            Console.ReadKey();
        }
    }
}
