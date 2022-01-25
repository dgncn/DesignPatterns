using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    public abstract class Car
    {
        public string Brand { get; }
        public string Model { get; }

        public string Type { get; set; }
    }
}
