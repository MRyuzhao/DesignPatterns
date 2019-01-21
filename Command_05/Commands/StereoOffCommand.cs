using System;
using Command_05.Devices;

namespace Command_05.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            Console.WriteLine("undo!!!");
            stereo.On();
        }
    }
}