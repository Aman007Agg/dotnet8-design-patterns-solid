using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Context Class: This class maintains a reference to a strategy object and is responsible 
    /// for executing the strategy. It allows clients to set or change the strategy at runtime, 
    /// enabling dynamic behavior changes without modifying the context class itself.
    /// </summary>
    internal class NavigationService
    {
        private ITravelStrategy travelStrategy;
        public NavigationService(ITravelStrategy travelStrategy)
        {
            this.travelStrategy = travelStrategy;
        }

        public void StartJourney()
        {
            Console.WriteLine("Starting the journey...");
            travelStrategy.Travel();
        }
    }
}
