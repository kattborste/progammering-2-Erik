using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaffeautomat
{
    public partial class Form1 : Form
    {
        public static double kronor10, kronor5, kronor2, kronor1, summa;
        public string dryck = "";
        Bitmap fyllt = Properties.Resources.kaffeglas;
        Bitmap tomt = Properties.Resources.tomtglas;

        public Form1()
        {
            InitializeComponent();
        }
        public void Omstart()
        {
            kronor10 = 0;
            kronor5 = 0;
            kronor2 = 0;
            kronor1 = 0;
            summa = 0;
            lbl10kr.Text = "";
            lbl5kr.Text = "";
            lbl2kr.Text = "";
            lbl1kr.Text = "";
            lblServeringDryck.Text = "";
            lblVäxelSumma.Text = "0";
            lblBetalningSumma.Text = "0";
            lblUppmaning.Text = "";
            pbxGlas.Image = tomt;
            KollaAllaDrycker();
        }
        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Cappuccino";
            summa -= Beställning.Cappuccino;
        }

        private void btnMocca_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Mocca";
            summa -= Beställning.Mocca;
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Espresso";
            summa -= Beställning.Espresso;
        }

        private void btnKaffelatte_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Kaffelatte";
            summa -= Beställning.Kaffelatte;
            
        }

        private void btnChoklad_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Choklad";
            summa -= Beställning.Choklad;
        }

        private void btnKaffe_Click(object sender, EventArgs e)
        {
            lblServeringDryck.Text = "Kaffe";
            summa -= Beställning.Kaffe;

        }

        private void btnKöp_Click(object sender, EventArgs e)
        {
            if (lblServeringDryck.Text != "")
            {
                pbxGlas.Image = fyllt;
                lblUppmaning.Text = "Klicka på drycken för att ta emot den";
                pbxGlas.Enabled = true;
                lblVäxelSumma.Text = Convert.ToString(summa);
            }
        }

        private void pbxGlas_Click(object sender, EventArgs e)
        {
            if (pbxGlas.Image == fyllt)
            {
                MessageBox.Show(Servering.HällDryck(lblServeringDryck.Text));
                Omstart();
                pbxGlas.Enabled = false;
            }
        }

        private void btn10kr_Click(object sender, EventArgs e)
        {
            kronor10++;
            summa += 10;
            lbl10kr.Text = Convert.ToString(kronor10);
            KollaAllaDrycker();
            lblBetalningSumma.Text = Convert.ToString(summa);
        }

        private void btn5kr_Click(object sender, EventArgs e)
        {
            kronor5++;
            summa += 5;
            lbl5kr.Text = Convert.ToString(kronor5);
            KollaAllaDrycker();
            lblBetalningSumma.Text = Convert.ToString(summa);
        }

        private void btn2kr_Click(object sender, EventArgs e)
        {
            kronor2++;
            summa += 2;
            lbl2kr.Text = Convert.ToString(kronor2);
            KollaAllaDrycker();
            lblBetalningSumma.Text = Convert.ToString(summa);
        }

        private void btn1kr_Click(object sender, EventArgs e)
        {
            kronor1++;
            summa += 1;
            lbl1kr.Text = Convert.ToString(kronor1);
            KollaAllaDrycker();
            lblBetalningSumma.Text = Convert.ToString(summa);
            
        }

        private void KollaPengar(double pengar, int kostnad, Button button)
        {
            if(pengar >= kostnad)
            {
                button.Enabled = true;
            }
            else 
            {
                button.Enabled = false;
            }
        }

        private void KollaAllaDrycker()
        {
            KollaPengar(summa, Beställning.Kaffe, btnKaffe);
            KollaPengar(summa, Beställning.Kaffelatte, btnKaffelatte);
            KollaPengar(summa, Beställning.Espresso, btnEspresso);
            KollaPengar(summa, Beställning.Cappuccino, btnCappuccino);
            KollaPengar(summa, Beställning.Choklad, btnChoklad);
            KollaPengar(summa, Beställning.Mocca, btnMocca);
        }
    }
}