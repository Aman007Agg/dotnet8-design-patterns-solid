using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class PaymentService
    {
        private readonly IPaymentRepository paymentRepository;
        private readonly ITransactionRepository transactionRepository;

        public PaymentService(IPaymentRepository paymentRepository, ITransactionRepository transactionRepository)
        {
            this.paymentRepository = paymentRepository;
            this.transactionRepository = transactionRepository;
        }
        
        public void MakePayment(string paymentMethodId, decimal amount)
        {
            var paymentMethod = paymentRepository.Get(paymentMethodId);
            if (paymentMethod == null)
            {
                Console.WriteLine($"Payment method with ID {paymentMethodId} not found.");
                return;
            }
            paymentMethod.Pay(amount);
            var transaction = new Transaction
            {
                PaymentMethodId = paymentMethodId,
                Amount = amount,
                TransactionDate = DateTime.Now
            };
            transactionRepository.Save(transaction);
        }
    }
}
