using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public abstract class Penguin : Flightless, ICanSwim
    {
        public abstract bool CanSwim { get; set; }

        public virtual bool NoChinStrap()
        {
            return false;
        }
    }
}
