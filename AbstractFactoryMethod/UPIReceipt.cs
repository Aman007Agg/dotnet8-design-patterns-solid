using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    internal class UPIReceipt: IReceipt
    {
        public void GenerateReceipt()
        {
            Console.WriteLine("Generating UPI payment receipt...");
            // Here you would add the logic to generate a receipt for the UPI payment
        }
    }
}
