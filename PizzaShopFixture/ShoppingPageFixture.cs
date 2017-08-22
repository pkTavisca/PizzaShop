using PizzaShoppingCenter;
using PizzaShoppingCenter.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaShopFixture
{

    public class ShoppingPageFixture
    {
        [Fact]
        public void Adding_a_pizza_sshould_return_true()
        {
            ShoppingPage page = new ShoppingPage();
            Assert.True(page.AddToCart("veg", new List<Toppings>(), PizzaSize.Large));
        }

        [Fact]
        public void Adding_a_wrong_pizza_sshould_return_false()
        {
            ShoppingPage page = new ShoppingPage();
            Assert.False(page.AddToCart("vefsdwsdg", null, PizzaSize.Large));
        }

        [Fact]
        public void Order_should_not_be_placed_if_cart_is_empty()
        {
            ShoppingPage page = new ShoppingPage();
            Assert.True(page.PlaceOrder().Equals("Order not placed."));
        }

        [Fact]
        public void Order_should_be_placed_if_cart_contains_anything()
        {
            ShoppingPage page = new ShoppingPage();
            page.AddToCart("veg", new List<Toppings>(), PizzaSize.Large);
            Assert.True(page.PlaceOrder().Equals("Order Placed."));
        }

        [Fact]
        public void SeeCart_should_return_a_non_empty_list_after_adding_pizzas()
        {
            ShoppingPage page = new ShoppingPage();
            page.AddToCart("veg", new List<Toppings>(), PizzaSize.Large);
            Assert.True(page.SeeCart().Count > 0);
        }
    }
}
