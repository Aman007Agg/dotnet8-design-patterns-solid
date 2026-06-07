using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    internal class UPI : IPaymentMethod
    {
        public string UpiId { get; set; }

        public UPI(string upiId)
        {
            UpiId = upiId;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine(
                $"UPI Payment of {amount:C} processed using {UpiId}");
        }
    }
}
