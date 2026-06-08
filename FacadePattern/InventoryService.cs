using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class InventoryService
    {
        public bool CheckStock(string product)
        {
            Console.WriteLine($"Checking stock for {product}");
            return true;
        }


    }
}
