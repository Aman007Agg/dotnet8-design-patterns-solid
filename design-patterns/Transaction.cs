using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class Transaction
    {
        public string PaymentMethodId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }


    }
}
