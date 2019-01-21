using FactoryMethod_02.PizzaType;
using SimpleFactory_01;

namespace FactoryMethod_02.PizzaStoreType
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new NYCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NYPepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYClamPizza();
                    break;
            }

            return pizza;
        }
    }
}