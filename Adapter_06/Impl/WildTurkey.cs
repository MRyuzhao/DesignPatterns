namespace Adapter_06.Impl
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            System.Console.WriteLine("Gobble gobble");
        }

        public void Gobble()
        {
            System.Console.WriteLine("I'm flying a short distance");
        }
    }
}