using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Koalas : Marsupials
    {
        public override bool Endangered { get; set; } = true;

        public override bool WarmBlooded { get; set; } = true;

        public override string Diet()
        {
            string dd = "Eucaplyptus leaves.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Groaning for eucalyptus.";
            return ss;
        }
    }
}
