using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sida;

            Console.Write("Hur lång är sidan på kuben?\t\t");
            sida = (Convert.ToDouble(Console.ReadLine()));

            Kub kuben = new Kub();
            
            kuben.Volym(sida); // Vi matar in sidans längd i volym- och ytberäkningarna
            kuben.Yta(sida);
            
            Console.ReadKey(); // Programmet avslutas när du klickar på valfri knapp

        }
    }
    class Kub
    {
        public void Volym(double sida)
        {
            double volym = (Math.Pow(sida, 3)); // Math.Pow = upphöjt med, dvs sidan^3
            Console.WriteLine("Kubens volym är " + volym);
        }

        public void Yta(double sida)
        {
            double yta = 6 * (Math.Pow(sida, 2));
            Console.WriteLine("Kubens yta är " + yta);
        }

    }
}