using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class UPIPayment: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount:C}");
            // Here you would add the logic to process the UPI payment
        }
    }
}
