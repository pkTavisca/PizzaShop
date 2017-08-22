using PizzaShoppingCenter.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter.Contracts
{
    public interface IPizza
    {
        string Name { get; }
        bool IsVeg { get; }
        PizzaSize Size { get; set; }
        List<Toppings> Toppings { get; set; }
    }
}
