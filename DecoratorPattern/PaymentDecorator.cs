using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// The PaymentDecorator class implements the IPaymentMethod interface and serves as a base class for all payment decorators.
    /// It holds a reference to an IPaymentMethod object and delegates the Pay method call to it. 
    /// This allows us to add additional behavior to the payment process without modifying the existing payment methods, adhering to the Open/Closed Principle.
    /// </summary>
    internal abstract class PaymentDecorator: IPaymentMethod
    {
        protected readonly IPaymentMethod _paymentMethod;
        protected PaymentDecorator(IPaymentMethod paymentMethod)
        {
            this._paymentMethod = paymentMethod;
        }

        public virtual void Pay(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }

    }
}
