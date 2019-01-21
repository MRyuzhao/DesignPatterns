using System;

namespace TemplateMethod_08
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("\nAdding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            if (answer == "yes")
            {
                return true;
            }
            return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with you coffee (y/n) ?");
            var keyInfo = Console.ReadKey();
            return keyInfo.KeyChar == 'y' ? "yes" : "no";
        }
    }
}