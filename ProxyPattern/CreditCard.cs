using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    internal class CreditCard: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of  {amount} processed.");
        }
    }
}
