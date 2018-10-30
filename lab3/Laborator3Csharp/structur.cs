using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator3Csharp
{
    class structur
    {
        public enum AccountType { CEC, Deposit };
        public struct BankAccount
        {
            public long accNumber;
            public int accInterest;
            public AccountType accType ;
        }
        class structure
        {
            public static void Main()
            {
                BankAccount account;
                account.accNumber = 123;
                account.accInterest = 6500;
                // Console.WriteLine("Introduceti accNumber");
                //account.accNumber = long.Parse(Console.ReadLine());
                // Console.WriteLine("Introduceti accInterest");
                // account.accInterest = int.Parse(Console.ReadLine());
                 account.accType = AccountType.CEC;
                Console.WriteLine(account.accNumber);
                Console.WriteLine(account.accInterest);
                Console.WriteLine(account.accType);
                Console.ReadLine();
            }
        }
    }
}
