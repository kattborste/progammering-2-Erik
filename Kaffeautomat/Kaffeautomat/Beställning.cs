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

        public static double betalatSumma;
        static double växel;

            
        public static double RäknaVäxel()
        {
           
            betalatSumma = (Form1.kronor10 * 10) + (Form1.kronor5 * 5) + (Form1.kronor2 * 2) + Form1.kronor1;
            växel = betalatSumma;
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
