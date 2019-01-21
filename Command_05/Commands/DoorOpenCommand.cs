using Command_05.Devices;

namespace Command_05.Commands
{
    public class DoorOpenCommand : ICommand
    {
        private readonly Door door;

        public DoorOpenCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Up();
        }

        public void Undo()
        {
            door.Down();
        }
    }
}