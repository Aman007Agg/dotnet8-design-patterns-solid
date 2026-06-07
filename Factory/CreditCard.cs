using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class CreditCard : IPaymentMethod
    {
        public string CardNumber { get; set; }
        public string UserName { get; set; }
        public decimal CreditLimit { get; set; }

        public CreditCard(string cardNumber, string userName, decimal creditLimit)
        {
            CardNumber = cardNumber;
            UserName = userName;
            CreditLimit = creditLimit;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Credit Card. " +
                $"Card Number: {CardNumber}, User Name: {UserName}, Credit Limit: {CreditLimit:C}");
        }
    }
}
