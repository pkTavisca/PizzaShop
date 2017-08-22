using PizzaShoppingCenter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaShoppingCenter.Constants;

namespace PizzaShoppingCenter.Pizzas
{
    public class VegPizza : IPizza
    {
        public bool IsVeg { get => true; }
        public PizzaSize Size { get; set; }
        public List<Toppings> Toppings { get; set; }
    }
}
