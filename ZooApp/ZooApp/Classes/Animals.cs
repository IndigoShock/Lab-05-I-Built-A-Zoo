using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Animals
    {
        public abstract string Sound();

        public abstract string Diet();

        public virtual bool Fur()
        {
            return true;
        }

    }
}
