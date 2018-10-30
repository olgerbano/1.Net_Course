using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simulare
{
    public enum AccountType { One_Years, Two_Years, Three_Years };
     delegate void Deposit(object sender, DepositArgs args);
    class Program
    {        
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
