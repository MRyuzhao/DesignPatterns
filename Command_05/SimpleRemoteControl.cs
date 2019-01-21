namespace Command_05
{
    public class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}