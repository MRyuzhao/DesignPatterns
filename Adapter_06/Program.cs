using System;
using Adapter_06.Impl;

namespace Adapter_06
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckTestDrive();
        }

        static void DuckTestDrive()
        {
            IDuck duck = new MallardDuck();
            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            System.Console.WriteLine("Turkey says.........");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine("Duck says.........");
            TestDuck(duck);
            Console.WriteLine("-----------------------------------------------------------");
            System.Console.WriteLine("TurkeyAdapter says.........");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
