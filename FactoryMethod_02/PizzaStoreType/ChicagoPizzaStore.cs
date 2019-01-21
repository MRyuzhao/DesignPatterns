using FactoryMethod_02.PizzaType;
using SimpleFactory_01;

namespace FactoryMethod_02.PizzaStoreType
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new ChicagoCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoPepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoClamPizza();
                    break;
            }

            return pizza;
        }
    }
}