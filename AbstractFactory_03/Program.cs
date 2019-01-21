using System;
using AbstractFactory_03.PizzaStoreType;

namespace AbstractFactory_03
{
    /// <summary>
    /// 现在披萨店在各地授权了很多连锁分店, 但是有的分店偷工减料, 使用劣质原料代替标准原料.
    /// 披萨店老板现在就是想解决这个问题.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza("cheese");

            Console.WriteLine("-----------------------------------------------------------");

            var chicagoYorkPizzaStore = new ChicagoPizzaStore();
            chicagoYorkPizzaStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
