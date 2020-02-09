using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("Cheese"))
                return new NYStyleCheesePizza();
            else if (item.Equals("Veggie"))
                return new NYStyleVeggiePizza();
            else if (item.Equals("Clam"))
                return new NYStyleClamPizza();
            else if (item.Equals("Pepperoni"))
                return new NYStylePepperoniPizza();
            else return null;
        }
    }
}
