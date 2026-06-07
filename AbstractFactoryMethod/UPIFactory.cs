using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class UPIFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            return new UPIPayment();
        }
        public IReceipt CreateReceipt()
        {
            return new UPIReceipt();
        }
    }
}
