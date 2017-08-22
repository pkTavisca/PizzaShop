using PizzaShoppingCenter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter
{
    public class ShoppingCart : IShoppingCart
    {
        public List<IPizza> Cart { get; set; }
    }
}
