using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class CreditCardPayment: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
            // Here you would add the logic to process the credit card payment
        }
    }
}
