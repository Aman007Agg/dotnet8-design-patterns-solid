using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class ShippingService
    {
        public void ShipOrder(string product)
        {
            Console.WriteLine($"Shipping {product}");
        }
    }
}
