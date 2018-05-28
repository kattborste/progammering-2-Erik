using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    class Konsult : Anställd
    {
        double arbetadeTimmar = 0;
        double timLön = 0;

        public Konsult(string namn, double arbetadeTimmar, double timLön) :base(namn)
        {
            this.arbetadeTimmar = arbetadeTimmar;
            this.timLön = timLön;
        }
        public override double BeräknaLön()
        {
            return timLön * arbetadeTimmar;
        }

        public override string ToString()
        {
            return namn + " (Konsult)";
        }
    }
}
