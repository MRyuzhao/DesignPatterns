using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class FrozenClams : IClams
    {
        public string Name { get; } = "Frozen Clams";
    }
}