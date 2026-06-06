using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class Dashboard: IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Dashboard Updated: Stock price updated to {price}");
        }
    }
}
