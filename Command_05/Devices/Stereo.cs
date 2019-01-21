namespace Command_05.Devices
{
    public class Stereo
    {
        public Stereo()
        {
            Volume = 5;
        }

        private int _volume;

        public int Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                System.Console.WriteLine($"Stereo's volume is set to {_volume}");
            }
        }

        public void On()
        {
            System.Console.WriteLine("Stereo is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("Stereo is off.");
        }

        public void SetCD()
        {
            System.Console.WriteLine("Stereo is set for CD input.");
        }

        public void SetVolume(int volume)
        {
            System.Console.WriteLine($"Stereo's volume is set to {volume}");
        }
    }
}