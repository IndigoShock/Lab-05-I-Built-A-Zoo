using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class ChinstrapPenguin : Penguin
    {
        public override bool CanSwim { get; set; } = true;

        public override string Diet()
        {
            string dd = "Little fishies";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Little squawks";
            return ss;

        }
    }
}
