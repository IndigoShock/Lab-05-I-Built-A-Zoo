using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class GilaMonster : Desert
    {
        public override bool Coldblooded { get; set; } = true;

        public override string Diet()
        {
            string dd = "Bugs and sand. Their pride.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Hiss, hiss, hiss~";
            return ss;
        }
    }
}
