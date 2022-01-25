using System;

namespace CarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üretilecek araba tipini seç: Sedan için S, Hatchback için H yazınız");
            string carType = Console.ReadLine();
            Console.WriteLine(MyCarFactory.CreateCar(carType)?.Type ?? string.Empty);
        }
    }
}
