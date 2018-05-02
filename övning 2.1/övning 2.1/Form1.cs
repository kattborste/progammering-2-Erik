using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBokReg_Click(object sender, EventArgs e)
        {
            Bok bok = new Bok(tbxBokTitel.Text, Convert.ToInt32(tbxBokSidor.Text));
            lbxBibliotek.Items.Add(bok);
            tbxBokTitel.Text = "";
            tbxBokSidor.Text = "";
        }

        private void btnLjudspårReg_Click(object sender, EventArgs e)
        {
            Ljudspår ljudspår = new Ljudspår(tbxLjudspårTitel.Text, Convert.ToInt32(tbxLjudspårSpeltid.Text));
            lbxBibliotek.Items.Add(ljudspår);
            tbxLjudspårTitel.Text = "";
            tbxLjudspårSpeltid.Text = "";
        }

        private void btnFilmReg_Click(object sender, EventArgs e)
        {
            Film film = new Film(tbxFilmTitel.Text, Convert.ToInt32(tbxFilmSpeltid.Text), tbxFilmUpplösning.Text);
            lbxBibliotek.Items.Add(film);
            tbxFilmTitel.Text = "";
            tbxFilmSpeltid.Text = "";
            tbxFilmUpplösning.Text = "";
        }
    }
}