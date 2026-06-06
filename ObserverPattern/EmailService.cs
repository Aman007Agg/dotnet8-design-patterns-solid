using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class EmailService: IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Email Service Alert: Stock price updated to {price}");
        }
    }
}
