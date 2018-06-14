using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Crocodile : Swamp
    {
        public override bool Coldblooded { get; set; } = true;

        public override string Diet()
        {
            string dd = "Zebras. Gazelles. Humans, sometimes. Be careful, yo.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "A cross between a hiss and a gasp.";
            return ss;
        }
    }
}
