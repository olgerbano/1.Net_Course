using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simulare
{
    class DepositArgs : EventArgs
    {
        private int accountid;
        private int amount;
        public DepositArgs(int accountid, int amount)
        {
            this.accountid = accountid;
            this.amount = amount;
        }

        public int get_accountid
        {
            get { return accountid; }
        }
        public int get_amount
        {
            get { return amount; }
        }
    }
}
