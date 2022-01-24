using System;

namespace SingletonDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = DisplayCardChip.GetInstance();
            var y = DisplayCardChip.GetInstance();
            Console.WriteLine(x == y);
        }
    }
}
