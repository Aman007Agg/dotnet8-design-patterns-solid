using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// Created State interface which will be implemented by all the concrete states.
    /// This interface will have a method to handle the state transition and any other methods that are relevant to the state.
    /// </summary>
    internal interface IOrderState
    {
        void Pay(Order order);
        void Ship(Order order);
        void Deliver(Order order);

    }
}
