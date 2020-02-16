using System.Collections.Generic;
using System.Linq;

namespace Cart.Core
{
    public class Cart
    {
        private readonly ICartRepository cartRepository;

        public Cart(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public void AddOrder(Order order)
        {
            cartRepository.AddOrder(order);
        }

        public decimal GetTotal()
        {
            var orders = cartRepository.GetAll();
            return orders.SelectMany(o => o.OrderLines).Sum(ol => ol.Price * ol.Units);
        }
    }

    public interface ICartRepository
    {
        void AddOrder(Order order);
        List<Order> GetAll();
    }
}
