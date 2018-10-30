using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simulare
{
    class Bank
    {
        private event Deposit depositMoney;
        System.Collections.ArrayList clients;
        public void Init()
        {
            clients = new System.Collections.ArrayList();
            // AccountType first = new AccountType();
            DepositAccount one = new DepositAccount("Andrei", AccountType.One_Years);
            //  AccountType second = new AccountType();
            DepositAccount two = new DepositAccount("Babale", AccountType.Two_Years);
            //   AccountType third = new AccountType();
            DepositAccount three = new DepositAccount("Mihai", AccountType.Three_Years);
            clients.Add(one);
            clients.Add(two);
            clients.Add(three);

        }
        public BankAccount this[int index]
        {
            get
            {
                object obj = clients[index];
                return (BankAccount)obj;
            }
        }

        public void CheckAccount(object sender, DepositArgs args)
        {
            foreach (DepositAccount ba in clients)
            {
                if (ba.GetAccountid == args.get_accountid)
                {
                    if (ba.getwithdrawrequest == true)
                        clients.Remove(ba);
                }
            }
        }
        public void DepositMoney(object sender, DepositArgs args)
        {
            foreach (DepositAccount ba in clients)
            {
                if (ba.GetAccountid == args.get_accountid)
                {
                    ba.MakeDeposit(args.get_amount);
                }

            }
        }
/*
        public DepositTrigger(int accountId, decimal amount)
        {

        }
        */
        public void List()
        {
            string inf = "null";
            string val = "informatiile : ";
            foreach (DepositAccount de in clients)
            {
                de.Info(ref val);
                inf += val;
            }
            Console.WriteLine(inf);
        }
    }
}
