using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class ReggianoCheese : ICheese
    {
        public string Name { get; } = "Reggiano Cheese";
    }
}