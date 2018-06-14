using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public abstract class Swamp : Reptiles, ICanSwim, ICanDig
    {
        public bool CanSwim { get; set; }
        public bool CanDig { get; set; }
        public virtual bool HasLegs { get; set; }
    }
}
