using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("Cheese"))
                return new ChicagoStyleCheesePizza();
            else if (item.Equals("Supreme"))
                return new ChicagoStyleSupremePizza();
            else return null;
        }
    }
}
