﻿namespace SimpleFactory_01.PizzaType
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Sauce = "Tomato sauce";
            Dough = "Soft dough";
            Toppings.Add("Shrimp meat");
        }
    }
}