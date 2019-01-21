using System;

namespace Singleton_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateBoiler = ChocolateBoiler.GetInstance();

            chocolateBoiler.Fill();
            chocolateBoiler.Fill();
            chocolateBoiler.Fill();

            Console.ReadKey();
        }
    }
}
