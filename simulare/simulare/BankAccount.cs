using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simulare
{
    class BankAccount
    {
        protected string name;
        protected int nrGenerator = 1234;
        protected int accountid;
        protected string logFile;

        public BankAccount(string name)
        {
            this.name = name;
            accountid = nrGenerator;
            nrGenerator++;
        }
        public string Getlogfile
        {
            get { return logFile; }
        }
        public string GetName
        {
            get { return name; }
        }
        public int  GetAccountid
        {
            get { return accountid; }
        }

        public virtual void Info(ref string date)
        {
           
                  date += " " + name + " " + nrGenerator + " " + accountid + " " + logFile;
 
        }

    }
}
