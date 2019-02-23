using System;
using Testability;

namespace Testability
{
    public class OrderProcessor
    {

        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already shipped.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShipmentDate = DateTime.Today.AddDays(1)
            };
        }

        
    }
}