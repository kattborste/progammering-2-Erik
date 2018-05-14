using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeautomat
{
    class Beställning
    {
       public static int Kaffe = 6;
       public static int Cappuccino = 12;
       public static int Mocca = 7;
       public static int Espresso = 13;
       public static int Kaffelatte = 10;
       public static int Choklad = 8;


            
        public static double RäknaVäxel() // Vi räknar ut växeln
        {
            if (Form1.summa > 0)
            {
                return Form1.summa;
            }
            else
            {
                return 0;
            }
        }
    }
}
