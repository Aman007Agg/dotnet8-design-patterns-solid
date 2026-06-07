using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class CreditCardReceipt: IReceipt
    {
        public void GenerateReceipt()
        {
            Console.WriteLine("Generating credit card payment receipt...");
            // Here you would add the logic to generate a receipt for the credit card payment
        }
    }
}
