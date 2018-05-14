using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1
{
    class Ljudspår : Media
    {
        protected double speltidL;

        public Ljudspår(string titel, double speltidL) : base(titel) // Ljudspårets titel och längd
        {
            this.speltidL = speltidL;
        }

        public override string ToString( // Innehållet förbereds för upphämtning
        {
            return titel + ": " + speltidL + " minuter";
        }
    }
}