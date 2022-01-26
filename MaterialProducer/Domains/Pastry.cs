using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialProducer.Domains
{
    public abstract class Pastry : Material
    {
        public string Color { get; set; }
        public Pastry(string type) : base(type)
        {

        }
        public static Pastry CreateCustomPastry(string type)
        {
            switch (type)
            {
                case "Pasta":
                    return new Pasta();
                case "Bread":
                    return new Bread();
                default:
                    return null;
            }
        }
    }
}
