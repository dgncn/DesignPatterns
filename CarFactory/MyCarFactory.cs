using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    public class MyCarFactory
    {
        public static Car CreateCar(string type)
        {
            switch (type)
            {
                case "S":
                    return new SedanCar();
                case "H":
                    return new HatchbackCar();
                default:
                    return null;
            }
        }
    }
}
