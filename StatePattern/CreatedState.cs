using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class CreatedState: IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Payment Successful.");
            order.SetState(new PaidState());
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order cannot be shipped. Payment is pending.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Order cannot be delivered. Payment is pending.");
        }
    }
}
