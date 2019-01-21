using System;

namespace SimpleFactory_01
{
    /// <summary>
    /// 有一个前沿的披萨店, 做披萨,但是, 一个披萨店不可能只有一种披萨, 可能会有很多种披萨,
    /// 一个披萨店会淘汰不畅销的披萨并添加新品种披萨
    /// </summary>
    class Program
    {
        static void Main()
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaStore.OrderPizza("cheese");

            Console.WriteLine("-----------------------------------------------------------");

            pizzaStore.OrderPizza("pepperoni");

            Console.ReadKey();
        }
    }
}
