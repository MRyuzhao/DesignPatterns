using Command_05.Devices;

namespace Command_05.Commands
{
    public class DoorCloseCommand : ICommand
    {
        private readonly Door door;

        public DoorCloseCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Down();
        }

        public void Undo()
        {
            door.Up();
        }
    }
}