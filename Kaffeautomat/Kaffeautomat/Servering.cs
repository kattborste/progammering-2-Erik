using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    class Servering
    {
        public static string HällDryck(string dryck) // När drycken tas emot så får vi följande meddelande
        {
            return "Du har tagit emot drycken " + dryck + " och fått " + 
            Convert.ToString(Beställning.RäknaVäxel()) + " kr tillbaks, ha en bra dag!";
        }
    }
}
