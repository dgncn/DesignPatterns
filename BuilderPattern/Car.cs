using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Car
    {
        public string Engine { get; set; }
        public double MinSpeed { get; set; }
        public int HorsePower { get; set; }

    }

    public class F1Car : Car
    {

    }
}
