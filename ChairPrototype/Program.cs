using System;

namespace ChairPrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClonableChair chair = new ClonableChair(MaterialTypeEnum.Iron, "White");
            var chair2 = chair.Clone();
            Console.WriteLine(chair == chair2);
        }
    }
}
