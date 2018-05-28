using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._2
{
    abstract class Anställd
    {
        protected string namn = "";
        public Anställd(string namn)
        {
            this.namn = namn;
        }
        public abstract double BeräknaLön();

        public override string ToString()
        {
            return namn;
        }
    }
}