using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new F1CarBuilder();
            CarController carController = new CarController(builder);
            carController.Build();

            Car car = builder.GetResult();
            Console.WriteLine($"car.MinSpeed: {car.MinSpeed} car.HorsePower:{car.HorsePower} car.Engine:{car.Engine} ");
        }
    }
}
