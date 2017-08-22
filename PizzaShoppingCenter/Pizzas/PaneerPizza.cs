using PizzaShoppingCenter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaShoppingCenter.Constants;

namespace PizzaShoppingCenter.Pizzas
{
    public class PaneerPizza : IPizza
    {
        public bool IsVeg => true;
        public PizzaSize Size { get; set; }
        public List<Toppings> Toppings { get; set; }

        public string Name => "Paneer Pizza";
    }
}
