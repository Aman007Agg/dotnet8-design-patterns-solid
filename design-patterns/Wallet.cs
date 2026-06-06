using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class Wallet: IPaymentMethod
    {
        public decimal WalletBalance { get; set; }

        public Wallet(decimal walletBalance)
        {
            WalletBalance = walletBalance;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"amount {amount} paid using Wallet");
        }
    }
}
