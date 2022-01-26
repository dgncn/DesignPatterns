using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialProducer.Domains
{
    public abstract class Car : Material
    {
        public string Brand { get; set; }

        public Car(string type) : base(type)
        {
            Type = type;
        }

        public static Car CreateCustomCar(string type)
        {
            switch (type)
            {
                case "HatchbackCar":
                    return new HatchbackCar();
                case "SedanCar":
                    return new SedanCar();
                default:
                    return null;
            }
        }
    }
}
