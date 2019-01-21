using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_03.IRawMaterial;
using AbstractFactory_03.RawMaterial;

namespace AbstractFactory_03.ConcreteFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
