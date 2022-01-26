using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class CarBuilder
    {
        public Car _car;
        public abstract void SetCarEngine();
        public abstract void SetEngineHP();
        public abstract void SetMinSpeed();
        public abstract void SetCar();
        public abstract Car GetResult();


    }
}
