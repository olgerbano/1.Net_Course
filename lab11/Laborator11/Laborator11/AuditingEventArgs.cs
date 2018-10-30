using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator11
{
    public class AuditEventArgs : System.EventArgs
    {
        private readonly BankTransaction transData = null;

        public AuditEventArgs(BankTransaction transData)
        {
            this.transData = transData;
        }

        public BankTransaction getTransaction() => this.transData;
    }
}
