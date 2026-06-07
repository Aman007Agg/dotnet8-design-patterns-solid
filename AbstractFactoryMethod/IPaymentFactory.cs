using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal interface IPaymentFactory
    {
        IPaymentMethod CreatePaymentMethod();
        IReceipt CreateReceipt();
    }
}
