using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class DebitCardFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            // In a real application, you might get these details from user input or a database
            string cardNumber = "9876-5432-1098-7654";
            string userName = "Aman Agrawal";
            decimal balance = 2000m;
            return new DebitCard(cardNumber, userName, balance);
        }
    }
}
