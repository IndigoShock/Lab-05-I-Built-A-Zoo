using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class NYCPidgeon : Flight
    {
        public override string FeatherColor { get; set; } = "Grey, white and a smidge of green. For envy.";

        public override string Diet()
        {
            string dd = "Let's be real. Probably bread crumbs. And trash.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Coo, man. Coo...";
            return ss;
        }
    }
}
