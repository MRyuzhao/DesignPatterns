using System;
using System.Collections;

namespace Iterator_09
{
    public partial class MyWaitress
    {
        private readonly ArrayList _menus;

        public MyWaitress(ArrayList menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            var menuIterator = _menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                var menu = menuIterator.Current as IMenu;
                PrintMenu(menu?.CreateIEnumerator());
            }
        }

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                if (iterator.Current != null)
                {
                    MenuItem menuItem;
                    if (iterator.Current is MenuItem item)
                    {
                        menuItem = item;
                    }
                    else
                    {
                        menuItem = ((DictionaryEntry)iterator.Current).Value as MenuItem;
                    }
                    Console.Write($"{menuItem?.Name}, ");
                    Console.Write($"{menuItem?.Price} -- ");
                    Console.WriteLine($"{menuItem?.Description}");
                }
            }
            Console.WriteLine();
        }
    }

}