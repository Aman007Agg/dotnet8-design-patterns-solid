using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class InMemoryTransactionRepository : ITransactionRepository
    {
        private List<Transaction> transactions = new List<Transaction>();
        public void Save(Transaction transaction)
        {
            transactions.Add(transaction);
            Console.WriteLine($"Transaction saved: {transaction.PaymentMethodId}, Amount: {transaction.Amount}, Date: {transaction.TransactionDate}");
        }
        public List<Transaction> GetAll()
        {
            return transactions;
        }
    }
}
