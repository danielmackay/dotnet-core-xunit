using Cart.Core;
using Xunit;
using NSubstitute;
using FluentAssertions;
using System.Collections.Generic;

namespace Cart.Tests
{
    public class CartTests
    {
        [Fact]
        public void Cart_Calculates_Correct_Sum()
        {
            // Arrange
            var orderRepo = Substitute.For<ICartRepository>();
            orderRepo.GetAll().ReturnsForAnyArgs(CreateOrders());
            var sut = new Core.Cart(orderRepo);

            // Act
            var result = sut.GetTotal();

            // Assert
            result.Should().Be(110);
        }

        private List<Order> CreateOrders() => new List<Order>
        {
            new Order
            {
                OrderLines = new List<OrderLine>
                {
                    new OrderLine{ Description = "Black Shoes", Price = 80.00M, Units = 1},
                    new OrderLine{ Description = "Striped Sockets", Price = 10.00M, Units = 3}
                }
            }
        };
    }
}
