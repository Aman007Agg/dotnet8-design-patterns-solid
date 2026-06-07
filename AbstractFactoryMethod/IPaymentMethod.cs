using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
