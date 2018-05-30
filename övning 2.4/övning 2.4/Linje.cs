using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    class Linje : Figur , iArea
    {
        public Linje(double bredd, double höjd) :base(bredd, höjd)
        {

        }

        public override double beräknaArea()
        {
            if(bredd == 0 || höjd == 0)
            {
                return 0;
            }
            else
            {
                return (bredd * höjd);
            }
        }


        public override string ToString()
        {
 	        return Convert.ToString("Linje: " + bredd + "x" + höjd);
        }
    }
}
