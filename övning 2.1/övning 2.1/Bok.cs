using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1
{
    class Bok : Media
    {
        protected int antalSidor = 0;

        public Bok(string titel, int antalSidor) : base(titel) // Vi kollar bokens titel och antalet sidor
        {
            this.antalSidor = antalSidor;
        }

        public override string ToString() // Innehållet förbereds för upphämtning
        { 
            return titel + ": " + antalSidor + " sidor"; 
        }
    }
}