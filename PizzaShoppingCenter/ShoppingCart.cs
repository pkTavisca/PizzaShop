using PizzaShoppingCenter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IPizza> _cart = new List<IPizza>();
        public void Add(IPizza pizza)
        {
            _cart.Add(pizza);
        }

        public List<IPizza> GetAllItems()
        {
            return _cart;
        }

        public void Remove(IPizza pizza)
        {
            _cart.Remove(pizza);
        }
    }
}
