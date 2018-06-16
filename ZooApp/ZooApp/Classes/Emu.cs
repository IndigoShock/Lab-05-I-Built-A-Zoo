using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Emu : Flightless
    {
        public override string Diet()
        {
            string dd = "I imagine it is grass, berries and haaaaaay.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Wah, wah, wah";
            return ss;
        }
    }
}
