using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class UPIFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            // In a real application, you might get these details from user input or a database
            string upiId = "aman@upi";
            return new UPI(upiId);
        }
    }
}
