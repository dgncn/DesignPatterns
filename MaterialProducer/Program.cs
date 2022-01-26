using MaterialProducer.Domains;
using System;

namespace MaterialProducer
{
    /// <summary>
    /// factory'den farkı, factory tek tip kapsamında soyutlama yaparken, abstract factory daha geniş perspektifte
    /// daha genel soyutlama yapar. çoklu tip soyutlaması yapar
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var objectType = MyMaterialFactory.CreateMaterial(new SedanCar());
            Console.WriteLine(objectType.Type);
        }
    }
}
