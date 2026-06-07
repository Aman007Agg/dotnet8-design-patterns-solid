using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    internal class LegacyPaymentAdapter : IPaymentMethod
    {
        private readonly LegacyPaymentGateway legacyPaymentGateway;

        public LegacyPaymentAdapter(LegacyPaymentGateway legacyPaymentGateway)
        {
            this.legacyPaymentGateway = legacyPaymentGateway;
        }

        public void Pay(decimal amount)
        {
            // Here we adapt the Pay method to call the MakePayment method of the legacy payment gateway.
            legacyPaymentGateway.MakePayment(amount);
        }
    }
    
}
