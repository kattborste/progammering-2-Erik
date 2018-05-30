using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._8
{
    class StyckSak : Vara
    {
        private double styckPris;
        private int antal;

        public StyckSak(string n, double p, int a) :base(n)
        {
            this.styckPris = p;
            this.antal = a;
        }

        public double StyckPris()
        {
            return styckPris;
        }
        public override double beräknaPris()
        {
            return styckPris * antal;
        }

        public override string ToString()
        {
            return namn + " " + antal + " st." + Convert.ToString(styckPris) + "kr/st. \t" + Convert.ToString(beräknaPris() + "kr");
        }
    }
}
