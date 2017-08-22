using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShoppingCenter.Contracts
{
    public interface IShoppingCart
    {
        void Add(IPizza pizza);
        void Remove(IPizza pizza);
        List<IPizza> GetAllItems();
    }
}
