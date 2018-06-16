using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Bonobos : Primates
    {
        public override bool WarmBlooded { get; set; } = true;

        public override string Diet()
        {
            string bb = "Bananas!";
            return bb;
        }

        public override bool Fur()
        {
            return true;
        }

        public override string Sound()
        {
            string ss = "Whoop, whoop!";
            return ss;
        }
    }
}
