using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns
{
    internal class UPI: IPaymentMethod
    {
        public string UpiId { get; set; }

        public UPI(string upiId)
        {
            UpiId = upiId;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"amount {amount} paid using UPI id: {UpiId}");
        }
    }
}
