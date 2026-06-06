using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// Create Subject Interface
    /// </summary>
    internal interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);

        void Notify();

    }
}
