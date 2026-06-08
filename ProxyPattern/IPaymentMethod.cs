using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}
