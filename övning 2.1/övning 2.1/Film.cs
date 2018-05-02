using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1
{
    class Film : Media
    {
        protected double speltidF;
        protected string upplösning;

        public Film(string titel, double spelTid, string upplösning) : base(titel)
        {
            this.speltidF = spelTid;
            this.upplösning = upplösning;
        }

        public override string ToString()
        {
            return titel + ": " + speltidF + " minuter, " + upplösning;
        }
    }
}