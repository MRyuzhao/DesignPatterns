namespace Command_05
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}