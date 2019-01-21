namespace Adapter_06.Impl
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying");
        }

        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}