using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace SuportLaborator10
{
    enum AccountType { Cec, Deposit }

    sealed class BankAccount : IDisposable
    {
        public BankAccount()
        {
            accNumber = NextNumber();
            amount = 0;
            accType = AccountType.Cec;
        }

        //supraincarcarea constructorului default

        public BankAccount(AccountType tCont)
        {
            accNumber = NextNumber();
            amount = 0;
            accType = tCont;
        }

        public BankAccount(decimal sCont)
        {
            accNumber = NextNumber();
            amount = sCont;
            accType = AccountType.Cec;
        }

        public BankAccount(AccountType tCont, decimal sCont)
        {
            accNumber = NextNumber();
            amount = sCont;
            accType = tCont;
        }

        //destructorul
        ~BankAccount()
        {
        }

        public long AccNumber
        {
            get
            {
                return accNumber;
            }
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }
        }

        public AccountType ReturnType
        {
            get
            {
                return accType;
            }
        }

        public string AccountOwner
        {
            get
            {
                return accountOwner;
            }
            set
            {
                accountOwner = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Numar cont - {0}, tip cont - {1}, suma - {2}, titular - {3}", AccNumber, ReturnType, Amount, AccountOwner);
        }

        public BankTransaction this[int ind]
        {
            get
            {
                if (ind < 0 || ind >= transactionQueue.Count)
                {
                    return null;
                }

                IEnumerator enumerator = transactionQueue.GetEnumerator();

                for (int i = 0; i <= ind; i++)
                {
                    enumerator.MoveNext();
                }
                return (BankTransaction)enumerator.Current;
            }
        }

        public static long NextNumber()
        {
            return succNrCont++;
        }
        public Queue Tranzactions()
        {
            return transactionQueue;
        }
        public static void Write(BankAccount cb)
        {
            Console.WriteLine("Nr de cont este: {0}", cb.AccNumber);
            Console.WriteLine("Soldul este: {0}", cb.Amount);
            Console.WriteLine("Tipul contului este: {0}", cb.ReturnType);

            for (int index = 0; index < cb.transactionQueue.Count; index++ )
            {
                Console.WriteLine("Data/Ora: {0}\tSuma: {1}", cb[index].Date, cb[index].Amount);
            }

            Console.WriteLine();
        }
        public decimal Deposit(decimal amount)
        {
            this.amount += amount;

            BankTransaction tran = new BankTransaction(amount);
            transactionQueue.Enqueue(tran);

            return this.amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > this.amount)
                return false;

            this.amount -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            
            transactionQueue.Enqueue(tran);

            return true;
        }

        public static void TestDeposit(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o depuneti");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Noul sold este: {0}", cb.Deposit(amount));
        }

        public static void TestWithdraw(BankAccount cb)
        {
            Console.WriteLine("Introduceti suma pe care vreti sa o retrageti");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (cb.Withdraw(amount) == true)
                Console.WriteLine("Noul sold este: {0}", cb.Amount);
            else
                Console.WriteLine("Suma este prea mare");
        }
        public void Dispose()
        {
            if (disposed == true)
                return;
            else
            {
                StreamWriter fout = File.AppendText("Tranzactii.txt");

                //scriem informatiile despre cont
                fout.WriteLine("Numarul de cont: {0}", accNumber);
                fout.WriteLine("Soldul: {0}", amount);
                fout.WriteLine("Tip cont: {0}", accType);

                foreach (BankTransaction tran in transactionQueue)
                {
                    fout.WriteLine("Data/Ora: {0}\tSuma: {1}", tran.Date, tran.Amount);
                }

                fout.WriteLine();
                fout.Close();

                disposed = true;

                GC.SuppressFinalize(this);
            }

        }
        private long accNumber; 
        private decimal amount;
        private AccountType accType;
        private static long succNrCont = 123;
        private string accountOwner;
        //coada de tranzactii
        private Queue transactionQueue = new Queue();

        //variabila de tip bool
        private bool disposed = false;
    }

}
