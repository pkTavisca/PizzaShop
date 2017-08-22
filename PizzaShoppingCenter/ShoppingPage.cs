using PizzaShoppingCenter.Constants;
using PizzaShoppingCenter.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaShoppingCenter
{
    public class ShoppingPage
    {
        public IShoppingCart Cart { get; private set; }

        public ShoppingPage()
        {
            Cart = new ShoppingCart();
        }

        public bool AddToCart(string pizzaString, List<Toppings> toppings, PizzaSize size)
        {
            if (PizzaFactory.GetPizza.ContainsKey(pizzaString) == false) return false;
            var pizza = PizzaFactory.GetPizza[pizzaString];
            pizza.Toppings = toppings;
            pizza.Size = size;
            Cart.Add(pizza);
            return true;
        }
        public void RemoveFromCart(IPizza pizza)
        {
            if (pizza != null)
                Cart.Remove(pizza);
        }
        public List<IPizza> SeeCart()
        {
            return Cart.GetAllItems();
        }
        public void PlaceOrder()
        {

        }
    }
}
