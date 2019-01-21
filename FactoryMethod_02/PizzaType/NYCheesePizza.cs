using SimpleFactory_01;

namespace FactoryMethod_02.PizzaType
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY Cheese Pizza";
            Dough = "Think Dough 2";
            Sauce = "Salad 2";
            Toppings.Add("Grated Reggiano Cheese 2");
        }
    }
}