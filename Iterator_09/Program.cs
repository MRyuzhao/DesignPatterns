using System;
using System.Collections;

namespace Iterator_09
{
    /// <summary>
    /// 有两个饭店合并了, 它们各自有自己的菜单. 饭店合并之后要保留这两份菜单.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new MyPancakeHouseMenu();
            var dinerMenu = new MyDinerMenu();

            var waitress = new MyWaitress(new ArrayList(2)
            {
                pancakeHouseMenu, dinerMenu
            });
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
