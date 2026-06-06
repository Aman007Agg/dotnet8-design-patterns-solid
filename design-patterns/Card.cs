using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal abstract class Card : IPaymentMethod
    {
        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Card number cannot be null or empty.");
                cardNumber = value;
            }
        }

        //private string userName;

        //public string UserName
        //{
        //    get { return userName; }
        //    set { userName = value; }
        //}

        public string UserName { get; set; }

        public abstract void Pay(decimal amount);

        public Card(string cardNumber, string userName)
        {
            //this.cardNumber = cardNumber;
            //this.userName = userName;
            CardNumber = cardNumber;
            UserName = userName;
        }

        public void DisplayCardInfo()
        {
            Console.WriteLine($"Card Number: {CardNumber}, User Name: {UserName}");
        }

    }
}
