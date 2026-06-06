using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class SMSService: IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"SMS Alert: Stock price updated to {price}");
        }
    }
}
