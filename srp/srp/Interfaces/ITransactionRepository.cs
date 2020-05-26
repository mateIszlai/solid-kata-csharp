using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp.Interfaces
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        List<Transaction> all();
    }
}
