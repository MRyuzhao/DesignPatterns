using System;

namespace FacadePattern_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new HomeTheaterFacade(new Door(), new Light());
            facade.WatchMovie();
            facade.EndMovie();

            Console.ReadKey();
        }
    }
}
