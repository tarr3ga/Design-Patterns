namespace FactoryPattern
{
    class NYStyleCheesePizza : Pizza
    {

        public NYStyleCheesePizza()
        {
            this.type = "New York style cheese pizza";
            this.dough = "Thin crust dough";
            this.sauce = "Marinara sauce";
            this.toppings.Add("Cheese");

            this.prepare();
            this.bake();
            this.cut();
            this.box();
        }
    }
}
