using System;

namespace ChairPrototype
{
    public class Chair
    {
        public MaterialTypeEnum MaterialType { get; set; }
        public string Color { get; set; }
    }

    public enum MaterialTypeEnum
    {
        Wood = 1,
        Iron = 2,
        Steel = 3
    };
}