using System;

namespace TemplateMethod_08
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void AddCondiments();
    }
}