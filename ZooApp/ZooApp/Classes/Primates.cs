using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public abstract class Primates : Mammals, ICanDig
    {
        public bool CanDig { get; set; } = true;
    }
}
