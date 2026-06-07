using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
