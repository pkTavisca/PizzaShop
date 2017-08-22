using PizzaShoppingCenter.Contracts;
using PizzaShoppingCenter.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter
{
    public class PizzaFactory
    {
        public static Dictionary<string, IPizza> GetPizza = new Dictionary<string, IPizza>()
        {
            {"veg",new VegPizza() },
            { "paneer", new PaneerPizza()}
        };
    }
}
