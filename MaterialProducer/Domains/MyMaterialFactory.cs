using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialProducer.Domains
{
    public abstract class MyMaterialFactory
    {
        public static Material CreateMaterial(Material material)
        {
            if (material is Pastry)
                return Pastry.CreateCustomPastry(material.Type);
            else if (material is Car)
                return Car.CreateCustomCar(material.Type);
            else
                return null;
        }
    }
}
