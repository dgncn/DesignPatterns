using System;

namespace SingletonLock
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisplayCardChip chip1 = DisplayCardChip.GetChip();
            DisplayCardChip chip2 = DisplayCardChip.GetChip();
            DisplayCardChip chip3 = DisplayCardChip.GetChip();
            DisplayCardChip chip4 = DisplayCardChip.GetChip();
            DisplayCardChip chip5 = DisplayCardChip.GetChip();
            DisplayCardChip chip6 = DisplayCardChip.GetChip();
            Console.WriteLine(chip6 == chip2);
        }
    }
}
