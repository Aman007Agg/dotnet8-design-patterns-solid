using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Strategy Interface: This interface defines a common method that all concrete strategies must implement.
    /// It allows the context to use different strategies interchangeably without knowing the details of their implementation.
    /// </summary>
    internal interface ITravelStrategy
    {
        void Travel();
    }
}
