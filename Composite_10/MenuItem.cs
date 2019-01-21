using System;

namespace Composite_10
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override double Price { get; }
        public override bool IsVegetarian { get; }

        public override void Print()
        {
            Console.Write($"\t{Name}");
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {Price}");
            Console.WriteLine($"\t\t -- {Description}");
        }
    }
}