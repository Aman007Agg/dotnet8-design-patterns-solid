using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class PaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of amount {amount} processed");
        }
    }
}
