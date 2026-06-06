using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class DebitCard : Card
    {
        public decimal AccountBalance { get; set; }

        public DebitCard(string cardNumber, string userName, decimal accountBalance) : base(cardNumber, userName)
        {
            AccountBalance = AccountBalance;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {AccountBalance}");
        }

        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment: {amount}");
        }
    }
}
