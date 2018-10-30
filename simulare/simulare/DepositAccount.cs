using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace simulare
{
    class DepositAccount : BankAccount , IDisposable
    {
        private bool withdrawRequest = false;
        private decimal amount;
        private decimal interestAmount;
        private AccountType account_type;

        public void Dispose()
        {
            Dispose();
            StreamWriter fout = File.AppendText("evidenta.txt");

            fout.WriteLine("S-a distrus un obiect");
                fout.WriteLine("nume: {0}", name);
                fout.WriteLine("accid: {0}", accountid);
                fout.WriteLine("Tip cont: {0}", account_type);
                fout.WriteLine("amount: {0}", amount);

                
                fout.WriteLine();
                fout.Close();

                withdrawRequest = true;

                GC.SuppressFinalize(this);
            
           
        }
        public DepositAccount(string name, AccountType account_type):base(name)
        {
            this.account_type = AccountType.One_Years;
        }
        public void MakeDeposit(int suma)
        {
            amount += suma;
            switch (account_type)
            {
                case AccountType.One_Years:
                    interestAmount += 6 * interestAmount/100 +suma;
                    break;
                case AccountType.Two_Years:
                    interestAmount += 8 * interestAmount/100 + suma;
                    break;
                case AccountType.Three_Years:
                    interestAmount += interestAmount/100 + suma;
                    break;
            }
            StreamWriter fout = File.AppendText(logFile);

            fout.WriteLine("S-a creat un obiect");
            fout.WriteLine("suma: {0}", suma);
            fout.WriteLine("amount: {0}", amount);
            fout.WriteLine("interest amount: {0}", interestAmount);
            fout.WriteLine();
            fout.Close();
        }
        public void WithDrawNow()
        {
            withdrawRequest = true;
        }
        public bool getwithdrawrequest
        {
            get { return withdrawRequest; }
        }
        public override void Info(ref string val)
        {
            base.Info(ref val);
            val += " " + amount + " " + interestAmount;

        }
    }
}
