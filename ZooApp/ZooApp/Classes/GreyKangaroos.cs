using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class GreyKangaroos : Marsupials
    {
        public override bool WarmBlooded { get; set; } = true;

        public override string Diet()
        {
            string dd = "Bugs, Berries and bogans...maybe not the last one. One wishes.";
            return dd;
        }

        public override string Sound()
        {
            string ss = "Kangaroo Jack raps.";
            return ss;
        }
    }
}
