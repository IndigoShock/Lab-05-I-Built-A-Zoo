using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class BoaConstrictor : Swamp
    {
        public override bool HasLegs { get; set; } = false;

        public override bool Coldblooded { get; set; } = true;

        public override string Diet()
        {
            string dd = "Large animals that are not often human.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Hisses and kisses";
            return ss;
        }
    }
}
