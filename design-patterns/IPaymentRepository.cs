using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal interface IPaymentRepository
    {
        void Add(string paymentMethodId, IPaymentMethod paymentMethod);

        IPaymentMethod Get(string paymentMethodId);
    }
}
