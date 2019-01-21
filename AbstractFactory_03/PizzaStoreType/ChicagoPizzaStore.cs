using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_03.ConcreteFactories;
using AbstractFactory_03.PizzaType;

namespace AbstractFactory_03.PizzaStoreType
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var factory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "Chicago Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
