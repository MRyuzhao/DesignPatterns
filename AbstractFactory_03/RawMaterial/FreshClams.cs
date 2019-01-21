using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_03.IRawMaterial;

namespace AbstractFactory_03.RawMaterial
{
    public class FreshClams : IClams
    {
        public string Name { get; } = "Fresh Clams";
    }
}
