using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class MarinaraSauce : ISauce
    {
        public string Name { get; } = "Marinara Sauce";
    }
}