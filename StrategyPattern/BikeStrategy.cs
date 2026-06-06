using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class BikeStrategy: ITravelStrategy
    {
        public void Travel()
        {
            Console.WriteLine($"Traveling by Bike: Pedaling to the destination using a bike.");
        }
    }
}
