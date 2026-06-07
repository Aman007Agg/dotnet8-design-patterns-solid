using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class ShippedState: IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Payment is already made.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Already shipped.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Order is being delivered.");
            order.SetState(new DeliveredState());
        }
    }
}
