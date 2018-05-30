using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._4
{
    class Triangel : Figur , iArea
    {
        public Triangel(double bredd, double höjd) : base(bredd, höjd)
        {

        }
        public override double beräknaArea()
        {
            return (bredd * höjd / 2);
        }

        public override string ToString()
        {
            return Convert.ToString("Triangel: " + bredd + "x" + höjd);
        }


        
    }
}
