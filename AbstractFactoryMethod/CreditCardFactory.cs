using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class CreditCardFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            return new CreditCardPayment();
        }

        public IReceipt CreateReceipt()
        {
            return new CreditCardReceipt();
        }

    }
}
