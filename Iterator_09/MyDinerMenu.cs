using System;
using System.Collections;

namespace Iterator_09
{
    public class MyDinerMenu : MyWaitress.IMenu
    {
        private const int MaxItems = 6;
        private int _numberOfItems = 0;
        private MenuItem[] MenuItems { get; }

        public MyDinerMenu()
        {
            MenuItems = new MenuItem[MaxItems];
            AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IEnumerator CreateIEnumerator()
        {
            return new MyDinerMenuIterator(MenuItems);
        }
    }
}