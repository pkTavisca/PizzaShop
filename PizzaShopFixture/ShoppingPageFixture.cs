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
    }
}
