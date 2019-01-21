using System;

namespace FacadePattern_07
{
    public class HomeTheaterFacade
    {
        private readonly Light _light;
        private readonly Door _door;

        public HomeTheaterFacade(Door door, Light light)
        {
            _door = door;
            _light = light;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie");

            _door.Up();
            _light.Up();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _door.Down();
            _light.Down();
        }
    }
}