namespace SimpleFactory_01.PizzaType
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Think Dough";
            Sauce = "Salad";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}