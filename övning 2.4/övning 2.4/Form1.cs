using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._4
{
    public partial class Form1 : Form
    {
        List<Figur> figurer = new List<Figur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            Triangel triangel = new Triangel(Convert.ToDouble(tbxBredd.Text), Convert.ToDouble(tbxHöjd.Text));
            lbxLista.Items.Add(triangel);
            figurer.Add(triangel);
            tbxBredd.Text = "";
            tbxHöjd.Text = "";
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel(Convert.ToDouble(tbxBredd.Text), Convert.ToDouble(tbxHöjd.Text));
            lbxLista.Items.Add(cirkel);
            figurer.Add(cirkel);
            tbxBredd.Text = "";
            tbxHöjd.Text = "";
        }

        private void btnLinje_Click(object sender, EventArgs e)
        {
            Linje linje = new Linje(Convert.ToDouble(tbxBredd.Text), Convert.ToDouble(tbxHöjd.Text));
            lbxLista.Items.Add(linje);
            figurer.Add(linje);
            tbxBredd.Text = "";
            tbxHöjd.Text = "";
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double sammanlagdArea = 0;

            foreach (Figur figur in figurer)
            {
                sammanlagdArea += figur.beräknaArea();
            }
            tbxArea.Text = Convert.ToString(sammanlagdArea);
        }
    }
}
