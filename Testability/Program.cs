using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testability
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order() { DatePlaced = DateTime.Now, TotalPrice = 30f };

            orderProcessor.Process(order);
        }
    }
}

