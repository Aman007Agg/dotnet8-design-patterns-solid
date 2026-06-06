using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class BusStrategy: ITravelStrategy
    {
        public void Travel()
        {
            Console.WriteLine($"Travelling by bus: Taking a bus to the destination.");
        }
    }
}
