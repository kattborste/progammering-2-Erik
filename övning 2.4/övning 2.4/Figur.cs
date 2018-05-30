using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    class Figur : iArea
    {
        protected double bredd;
        protected double höjd;
        public Figur(double bredd, double höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }

        public virtual double beräknaArea()
        {
            return 0;
        }
    }
}
