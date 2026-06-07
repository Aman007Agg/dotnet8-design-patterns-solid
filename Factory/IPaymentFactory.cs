using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// Factory Interface
    /// </summary>
    internal interface IPaymentFactory
    {
        IPaymentMethod CreatePaymentMethod();
    }
}
