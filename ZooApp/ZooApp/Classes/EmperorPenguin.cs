using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class EmperorPenguin : Penguin
    {
        public override bool CanSwim { get; set; } = true;

        public override string Diet()
        {
            string dd = "Big fishies";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Big squawks.";
            return ss;
        }
    }
}
