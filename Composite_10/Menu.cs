using System;
using System.Collections.Generic;

namespace Composite_10
{
    public class Menu : MenuComponent
    {
        readonly List<MenuComponent> _menuComponents;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuComponents = new List<MenuComponent>();
        }

        public override string Name { get; }
        public override string Description { get; }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            Console.Write($"\n{Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine("------------------------------");

            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}