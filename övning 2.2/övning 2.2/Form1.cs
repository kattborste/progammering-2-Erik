using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._2
{
    public partial class Form1 : Form
    {
        List<Anställd> anställda = new List<Anställd>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegFörs_Click(object sender, EventArgs e)
        {
            Säljare säljare = new Säljare(tbxNamnS.Text, Convert.ToDouble(tbxProvision.Text), Convert.ToDouble(tbxFörsäljning.Text));
            anställda.Add(säljare);
            lbxRegister.Items.Add(säljare);
            lbxLönutb.Items.Add(säljare + ": " + säljare.BeräknaLön().ToString());
            tbxNamnS.Text = ""; 
            tbxProvision.Text = "";
            tbxFörsäljning.Text = "";
        }

        private void btnRegArb_Click(object sender, EventArgs e)
        {
            Konsult konsult = new Konsult(tbxNamnKons.Text, Convert.ToDouble(tbxTimlön.Text), Convert.ToDouble(tbxArbetstid.Text));
            anställda.Add(konsult);
            lbxRegister.Items.Add(konsult);
            lbxLönutb.Items.Add(konsult + ": " + konsult.BeräknaLön().ToString());
            tbxNamnKons.Text = "";
            tbxTimlön.Text = "";
            tbxArbetstid.Text = "";

        }

        private void btnRegLön_Click(object sender, EventArgs e)
        {
            Kontorist kontorist = new Kontorist(tbxNamnKont.Text, Convert.ToDouble(tbxMånadslön.Text));
            anställda.Add(kontorist);
            lbxRegister.Items.Add(kontorist);
            lbxLönutb.Items.Add(kontorist + ": " + kontorist.BeräknaLön().ToString());
            tbxNamnKont.Text = "";
            tbxMånadslön.Text = "";
            

        }

        private void btnRäknalön_Click(object sender, EventArgs e)
        {
            double lön = 0;
            foreach (Anställd anställd in anställda)
            {
                lön += anställd.BeräknaLön();
            }
            lblLön.Text = Convert.ToString(lön);
        }
    }
}