namespace BuilderPattern
{
    public class F1CarBuilder : CarBuilder
    {
        public override void SetCar()
        {
            _car = new Car();
        }

        public override Car GetResult()
        {
            return _car;
        }

        public override void SetCarEngine()
        {
            _car.Engine = "Honda RA807E";
        }

        public override void SetEngineHP()
        {
            _car.HorsePower = 350;
        }

        public override void SetMinSpeed()
        {
            _car.MinSpeed = 170;
        }
    }
}
