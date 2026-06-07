using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class WalletFactory: IPaymentFactory
    {
        public IPaymentMethod CreatePaymentMethod()
        {
            // In a real application, you might get these details from user input or a database
            decimal balance = 1000m;
            return new Wallet(balance);
        }
    }
}
