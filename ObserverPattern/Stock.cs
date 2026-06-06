using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class Stock : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                Notify();
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(price);
            }
        }
    }
}
