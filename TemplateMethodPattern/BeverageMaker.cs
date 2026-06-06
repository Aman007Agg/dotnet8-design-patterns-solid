using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a method,
    /// called the template method, and allows subclasses to override specific steps of the algorithm without changing its structure.
    /// </summary>
    internal abstract class BeverageMaker
    {
        public void MakeBeverage()
        {
            BoilWater();
            AddIngredients();
            PourIntoCup();
            Serve();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }
        public void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup...");
        }
        public void Serve()
        {
            Console.WriteLine("Serving the beverage...");
        }

        protected abstract void AddIngredients();
    }
}
