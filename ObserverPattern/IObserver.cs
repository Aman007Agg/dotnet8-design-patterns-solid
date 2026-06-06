using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Create Observer Interface
    /// </summary>
    internal interface IObserver
    {
        void Update(decimal price);
    }
}
