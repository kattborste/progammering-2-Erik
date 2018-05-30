using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._8
{
    class LösVikt : Vara
    {
        private double kiloPris;
        private double vikt;

        public LösVikt(string n, double p, double v) :base(n)
        {
            this.kiloPris = p;
            this.vikt = v;
        }

        public double KiloPris()
        {
            return kiloPris;
        }
        public double Vikt()
        {
            return vikt;
        }
        public override double beräknaPris()
        {
            return vikt * kiloPris;
        }

        public override string ToString()
        {
            return namn + " " + vikt + " kg" + Convert.ToString(kiloPris) + "kr/kg. \t" + Convert.ToString(beräknaPris() + "kr");
        }
    }
}