using System;
namespace Testability
{
    public class OrderProcessor
    {
        public readonly IShippingCalculator ShippingCalcularor;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            ShippingCalcularor = shippingCalculator;
        }

        public void Process (Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");

            order.Shipment = new Shipment
            {
                Cost = ShippingCalcularor.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
