using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal interface IPaymentMethod
    {
        void Pay(decimal amoount);
    }
}
