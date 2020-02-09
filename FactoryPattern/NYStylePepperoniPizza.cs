using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            this.type = "New York style pepperoni pizza";
            this.dough = "Thin crust dough";
            this.sauce = "Marinara sauce";
            this.toppings.Add("Cheese");
            this.toppings.Add("Pepperoni");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
