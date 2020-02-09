﻿using System;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(String type)
        {
            Pizza pizza;

            pizza = createPizza(type);

            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }
}
