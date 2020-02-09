using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.type = "Chicago style pepperoni pizza";
            this.dough = "Deep diah crust dough";
            this.sauce = "Plum tomato sauce";
            this.toppings.Add("Cheese");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
