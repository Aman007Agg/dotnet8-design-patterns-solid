using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class Order
    {
        private IOrderState state;

        public Order()
        {
            state = new CreatedState();
        }

        public void SetState(IOrderState state)
        {
            this.state = state;
        }

        public void Pay()
        {
            state.Pay(this);
        }

        public void Ship()
        {
            state.Ship(this);
        }

        public void Deliver()
        {
            state.Deliver(this);
        }
    }
}
