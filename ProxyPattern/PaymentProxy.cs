using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    internal class PaymentProxy : IPaymentMethod
    {
        private readonly CreditCard creditCard;
        private readonly bool isAdmin;

        public PaymentProxy(bool isAdmin)
        {
            creditCard = new CreditCard();
            this.isAdmin = isAdmin;
        }

        public void Pay(decimal amount)
        {
            if(amount > 50000 && !isAdmin)
            {
                Console.WriteLine("Access Denied");
                return;
            }
            creditCard.Pay(amount);
        }
    }
}
