using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CarController
    {
        CarBuilder _carBuilder;
        public CarController(CarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void Build()
        {
            _carBuilder.SetCar();
            _carBuilder.SetMinSpeed();
            _carBuilder.SetEngineHP();
            _carBuilder.SetCarEngine();
            
        }
    }
}
