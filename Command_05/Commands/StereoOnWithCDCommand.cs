using Command_05.Devices;

namespace Command_05.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private int previousVolume;
        private readonly Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
            previousVolume = stereo.Volume;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.Volume = 10;
            //stereo.SetVolume(10);
        }

        public void Undo()
        {
            stereo.Off();
            stereo.Volume = previousVolume;
        }
    }
}