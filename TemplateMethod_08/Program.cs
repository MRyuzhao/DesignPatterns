using System;

namespace TemplateMethod_08
{
    /// <summary>
    /// 有一家咖啡店, 供应咖啡和茶, 可以看到咖啡和茶的制作工序是差不多的,
    /// 都是有4步, 其中有两步它们两个是一样的,
    /// 另外两步虽然具体内容不一样, 但是都做做的同一类工作.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("-----------------------------------------------------------");

            var coffeeWithHook = new CoffeeWithHook();
            Console.WriteLine("Making coffee...");
            coffeeWithHook.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
