using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class PlumTomatoSauce : ISauce
    {
        public string Name { get; } = "Plum Tomato Sauce";
    }
}