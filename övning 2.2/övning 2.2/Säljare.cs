using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Säljare : Anställd
    {
        protected double provision = 0;
        protected double försäljning = 0;

        public Säljare(string namn, double provision, double försäljning) :base(namn)
        {
            this.provision = provision;
            this.försäljning = försäljning;
        }

        public override double BeräknaLön()
        {
            return försäljning * provision / 100;
        }
        public override string ToString()
        {
            return namn + " (Säljare)";
        }
    }
}
