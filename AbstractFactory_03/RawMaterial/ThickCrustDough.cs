using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class ThickCrustDough : IDough
    {
        public string Name { get; } = "Thick Crust Dough";
    }
}