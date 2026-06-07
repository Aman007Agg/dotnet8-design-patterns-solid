using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class DeliveredState: IOrderState
    {
        public void Pay(Order order)
        {
            Console.WriteLine("Payment is already made.");
        }

        public void Ship(Order order)
        {
            Console.WriteLine("Order is already shipped.");
        }

        public void Deliver(Order order)
        {
            Console.WriteLine("Order is already delivered.");
        }
    }
}
