using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class Wallet: IPaymentMethod
    {
        public decimal Balance { get; set; }

        public Wallet(decimal balance)
        {
            Balance = balance;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine(
                $"Wallet Payment of {amount:C} processed");
        }
    }
}
