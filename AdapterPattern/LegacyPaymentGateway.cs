using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// This is the legacy payment gateway that we want to adapt to our new system. 
    /// It has a different interface than the one we want to use, so we will create an adapter for it.
    /// </summary>
    internal class LegacyPaymentGateway
    {
       public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Making payment of {amount} using Legacy Payment Gateway.");
        }
    }
}
