using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class OrderFacade
    {
        private readonly InventoryService inventoryService;
        private readonly PaymentService paymentService;
        private readonly ShippingService shippingService;

        public OrderFacade()
        {
            inventoryService = new InventoryService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();

        }

        public void PlaceOrder(string product, decimal amount)
        {
            if (inventoryService.CheckStock(product))
            {
                paymentService.ProcessPayment(amount);
                shippingService.ShipOrder(product);
            }
        }
    }
}
