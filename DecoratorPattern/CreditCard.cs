using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class CreditCard: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }
}
