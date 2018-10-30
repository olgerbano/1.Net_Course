using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SolutieLaborator11
{
    class Audit
    {
        private bool closed;
        private string filename;
        private StreamWriter auditFile;
        public Audit(string fileToUse)
        {
            closed = false;
            this.filename = fileToUse;
            this.auditFile = File.AppendText(fileToUse);
        }

        public void RecordTransaction(object sender, AuditEventArgs eventData)
        {
            BankTransaction tempTrans = eventData.getTransaction();
            if (tempTrans != null)
                this.auditFile.WriteLine("Amount: {0}\tDate: {1}", tempTrans.Amount(), tempTrans.Date());
        }

        public void Close()
        {
            if (!closed)
            {
                this.auditFile.Close();
                closed = true;
            }
        }
    }
}
