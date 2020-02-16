using System.Collections.Generic;

namespace Cart.Core
{
    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}
