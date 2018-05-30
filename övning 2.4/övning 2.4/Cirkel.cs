using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    class Cirkel : Figur , iArea
    {

        public Cirkel(double bredd, double höjd) :base(bredd,höjd)
        {

        }

        public override double beräknaArea()
        {
            return (bredd / 2) * (bredd / 2) * Math.PI;
        }

        public override string ToString()
        {
            return Convert.ToString("Cirkel: " + bredd + "x" + höjd);
        }
    }
}
