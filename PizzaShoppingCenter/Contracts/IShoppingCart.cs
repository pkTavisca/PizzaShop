using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter.Contracts
{
    public interface IShoppingCart
    {
        List<IPizza> Cart { get; set; }
    }
}
