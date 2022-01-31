using System;
using System.Collections.Generic;
using System.Text;

namespace ChairPrototype
{
    public class ClonableChair : Chair, ICloneable
    {
        //Chair chair;
        public ClonableChair(MaterialTypeEnum materialTypeEnum, string color)
        {
            this.MaterialType= materialTypeEnum;
            this.Color= color;
        }
        public ClonableChair Clone()
        {
            return (ClonableChair)base.MemberwiseClone();
        }
    }
}
