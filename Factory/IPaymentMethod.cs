using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
