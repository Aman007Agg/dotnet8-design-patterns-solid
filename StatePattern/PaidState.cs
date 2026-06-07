using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class PaidState: IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Payment is already made.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order is being shipped.");
            order.SetState(new ShippedState());
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Order cannot be delivered. It is still being processed.");
        }
    }
}
