using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class InMemoryPaymentRepository: IPaymentRepository
    {
        private Dictionary<string, IPaymentMethod> paymentMethods;
        public InMemoryPaymentRepository()
        {
            paymentMethods = new Dictionary<string, IPaymentMethod>();
        }
        public void Add(string paymentMethodId, IPaymentMethod paymentMethod)
        {
            paymentMethods[paymentMethodId] = paymentMethod;
        }
        public IPaymentMethod Get(string paymentMethodId)
        {
            if (paymentMethods.TryGetValue(paymentMethodId, out IPaymentMethod paymentMethod))
            {
                return paymentMethod;
            }
            else
            {
                Console.WriteLine($"Payment method with ID {paymentMethodId} not found.");
                return null;
            }
        }
    }
}
