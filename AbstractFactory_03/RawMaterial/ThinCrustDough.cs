using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class ThinCrustDough : IDough
    {
        public string Name { get; } = "Thin Crust Dough";
    }
}