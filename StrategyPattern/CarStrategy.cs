using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class CarStrategy: ITravelStrategy
    {
        public void Travel()
        {
            Console.WriteLine($"Traveling by Car: Driving to the destination using a car.");
        }
    }
}
