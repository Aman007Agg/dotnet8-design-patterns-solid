using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal interface ITransactionRepository
    {
        void Save(Transaction transaction);
        List<Transaction> GetAll();
    }
}
