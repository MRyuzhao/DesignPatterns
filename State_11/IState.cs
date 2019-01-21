namespace State_11
{
    public interface IState
    {
        void InjectQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}