using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    public class Transaction
    {
        private DateTime date;
        private int amount;

        public Transaction(DateTime date, int amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public DateTime Date()
        {
            return date;
        }

        public int Amount()
        {
            return amount;
        }
    }
}
