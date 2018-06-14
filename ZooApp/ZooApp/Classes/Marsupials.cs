using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Marsupials : Mammals
    {
        public virtual bool Endangered { get; set; }
    }
}
