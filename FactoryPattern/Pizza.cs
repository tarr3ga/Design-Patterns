using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        protected string type;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public Pizza createPizza(string type)
        {
            this.type = type;

            return this;
        }

        public void prepare() {
            Console.WriteLine("Preparing " + type);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding " + sauce + " sauce...");
            Console.WriteLine("Adding toppings...");
            foreach(string s in toppings)
            {
                Console.WriteLine(s);
            }
        }

        public void bake() {
            Console.WriteLine("Baking for 20 minutes at 350...");
        }

        public void cut() {
            Console.WriteLine("Cutting pizza...");
        }

        public void box() {
            Console.WriteLine("Boxing pizza...");
            Console.WriteLine("");
        }
    }
}
