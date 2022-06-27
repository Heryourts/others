using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Transaction
    {
        public string Note { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; private set; }

        public Transaction()
        {
            Date = DateTime.Now;
        }
    }
}
