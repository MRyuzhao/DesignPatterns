using System;

namespace Command_05.Devices
{
    public class Door
    {
        public void Up()
        {
            Console.WriteLine("GarageDoor is opened.");
        }

        public void Down()
        {
            Console.WriteLine("GarageDoor is closed.");
        }
    }
}