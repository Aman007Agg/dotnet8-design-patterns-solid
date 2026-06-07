using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class DebitCard : IPaymentMethod
    {
        public string CardNumber { get; set; }

        public string UserName { get; set; }

        public decimal Balance { get; set; }

        public DebitCard(
            string cardNumber,
            string userName,
            decimal balance)
        {
            CardNumber = cardNumber;
            UserName = userName;
            Balance = balance;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Debit Card. " +
                $"Card Number: {CardNumber}, User Name: {UserName}, Balance: {Balance:C}");
        }
    }
}
