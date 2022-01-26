namespace BuilderPattern
{
    public class F2CarBuilder : CarBuilder
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
            _car.Engine = "HAAS Standart Engine";
        }

        public override void SetEngineHP()
        {
            _car.HorsePower = 250;
        }

        public override void SetMinSpeed()
        {
            _car.MinSpeed = 100;
        }
    }
}
