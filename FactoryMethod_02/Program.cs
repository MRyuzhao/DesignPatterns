using System;
using FactoryMethod_02.PizzaStoreType;

namespace FactoryMethod_02
{
    /// <summary>
    /// 披萨店开的很好, 所以老板在全国各地开授权连锁分店了, 而每个地点的分店根据当地居民的口味,
    /// 它们所提供的披萨种类可能会不同.例如纽约和芝加哥和加利福尼亚的就有可能不同.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ordered a {pizza.Name} in NY");

            Console.WriteLine("-----------------------------------------------------------");

            var pizza2 = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Ordered a {pizza2.Name} in Chicago");

            Console.ReadKey();
        }
    }
}
