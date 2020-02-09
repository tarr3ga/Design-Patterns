using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            this.type = "New York style veggie pizza";
            this.dough = "Thin crust dough";
            this.sauce = "Marinara sauce";
            this.toppings.Add("Cheese");
            this.toppings.Add("Tomatoes");
            this.toppings.Add("Cucumber");
            this.toppings.Add("Olives");
            this.toppings.Add("Eggpant");
            this.toppings.Add("Feta Cheese");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
