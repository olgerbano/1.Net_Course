using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator3Csharp
{
    public class Enume
    {
        enum AccountType
        {
            CEC, Deposit
        };
        public static void Main()
        {
            AccountType account1, account2;
            account1 = AccountType.CEC;
            account2 = AccountType.Deposit;
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.ReadKey();
        }
    }
}
