using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Penguin : Flightless
    {
        public virtual bool NoChinStrap()
        {
            return false;
        }
    }
}
