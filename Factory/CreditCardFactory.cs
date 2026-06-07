using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class CreditCardFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            // In a real application, you might get these details from user input or a database
            string cardNumber = "1234-5678-9012-3456";
            string userName = "Aman Agrawal";
            decimal creditLimit = 5000m;
            return new CreditCard(cardNumber, userName, creditLimit);
        }
    }
}
