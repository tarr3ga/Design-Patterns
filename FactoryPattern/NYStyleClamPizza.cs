using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            this.type = "New York style clam pizza";
            this.dough = "Thin crust dough";
            this.sauce = "Fish sauce";
            this.toppings.Add("Cheese");
            this.toppings.Add("Clams");
            this.toppings.Add("More clams");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
