using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
    
}
