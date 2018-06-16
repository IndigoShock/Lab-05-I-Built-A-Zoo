using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Chimpanzees : Primates
    {
        public override bool WarmBlooded { get; set; } = true;

        public override string Diet()
        {
            string bb = "Oh you know: Bananas, nuts, other chimps. The usual";
            return bb;
        }

        public override string Sound()
        {
            string ss = "Screeches in the background";
            return ss;
        }
    }
}
