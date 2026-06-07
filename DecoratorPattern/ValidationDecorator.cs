using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class ValidationDecorator: PaymentDecorator
    {
        public ValidationDecorator(IPaymentMethod paymentMethod) : base(paymentMethod)
        {
        }
        public override void Pay(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Payment failed.");
                return;
            }
            Console.WriteLine("Validation Passed");
            base.Pay(amount);
        }
    }
}
