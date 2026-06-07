using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class LoggingDecorator: PaymentDecorator
    {
        public LoggingDecorator(IPaymentMethod paymentMethod) : base(paymentMethod)
        {

        }

        public override void Pay(decimal amount)
        {
            Console.WriteLine("Logging Started");
            base.Pay(amount);
            Console.WriteLine("Logging Ended");
        }
    }
}
