using PizzaShoppingCenter;
using PizzaShoppingCenter.Contracts;
using PizzaShoppingCenter.Pizzas;
using System;
using Xunit;

namespace PizzaShopFixture
{
    public class ShoppingCartFixture
    {
        [Fact]
        public void Adding_a_pizza_should_increase_length_of_cart()
        {
            IPizza veg = new VegPizza();
            IShoppingCart cart = new ShoppingCart();
            cart.Add(veg);
            Assert.True(cart.GetAllItems().Count == 1);
        }

        [Fact]
        public void Removing_a_pizza_from_cart()
        {
            IPizza veg = new VegPizza();
            IShoppingCart cart = new ShoppingCart();
            cart.Add(veg); cart.Add(veg); cart.Add(veg);

            cart.Remove(veg);

            Assert.True(cart.GetAllItems().Count == 2);
        }
    }
}
