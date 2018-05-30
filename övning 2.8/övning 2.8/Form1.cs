using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._8
{
    public partial class Form1 : Form
    {
        List<Vara> varor = new List<Vara>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            double summa = 0;
            if (rbnLösvikt.Checked)
            {
                LösVikt lösvikt = new LösVikt(tbxVara.Text, Convert.ToDouble(tbxPris.Text), Convert.ToInt32(tbxMängd.Text));
                lbxLista.Items.Add(lösvikt);
                varor.Add(lösvikt);
                tbxVara.Text = "";
                tbxPris.Text = "";
                tbxMängd.Text = "";
            }
            else if (rbnStycksak.Checked)
            {
                StyckSak stycksak = new StyckSak(tbxVara.Text, Convert.ToDouble(tbxPris.Text), Convert.ToInt32(tbxMängd.Text));
                lbxLista.Items.Add(stycksak);
                varor.Add(stycksak);
                tbxVara.Text = "";
                tbxPris.Text = "";
                tbxMängd.Text = "";
            }

            foreach (Vara vara in varor)
            {
                summa += vara.beräknaPris();
            }
            tbxSumma.Text = Convert.ToString(summa);
        }
    }
}
