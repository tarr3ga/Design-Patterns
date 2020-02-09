using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ChicagoStyleSupremePizza : Pizza
    {
        public ChicagoStyleSupremePizza()
        {
            this.type = "Chicago style supreme pizza";
            this.dough = "Deep diah crust dough";
            this.sauce = "Plum tomato sauce";
            this.toppings.Add("Cheese");
            this.toppings.Add("Peperoni");
            this.toppings.Add("Sauage");
            this.toppings.Add("Mushrooms");
            this.toppings.Add("Green peppers");
            this.toppings.Add("Black Olives");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
