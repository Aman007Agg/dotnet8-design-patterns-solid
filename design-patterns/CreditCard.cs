using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class CreditCard : Card
    {
        public decimal CreditLimit { get; set; }

        public CreditCard(string cardNumber, string userName, decimal creditLimit) : base(cardNumber, userName)
        {
            CreditLimit = creditLimit;
        }

        public void ShowCreditLimit()
        {
            Console.WriteLine($"Credit Limit: {CreditLimit}");
        }

        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Credit Payment: {amount} processed for {UserName}");
        }

    }
}
