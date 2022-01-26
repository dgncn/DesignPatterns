using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialProducer.Domains
{
    public class Material
    {
        public string Type { get; set; }
        public Material(string type)
        {
            Type = type;
        }

    }
}
