using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Flamingo : Flight
    {
        public override string FeatherColor { get; set; } = "Pink";

        public override string Diet()
        {
            string dd = "Fish? I bet they eat their dancings.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Honk, honk...(they look prettier than they sound)";
            return ss;
        }
    }
}
