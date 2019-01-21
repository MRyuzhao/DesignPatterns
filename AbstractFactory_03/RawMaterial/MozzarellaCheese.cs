using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class MozzarellaCheese : ICheese
    {
        public string Name { get; } = "Mozzarella Cheese";
    }
}