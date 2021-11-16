using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskinler_Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt32(txtmisir.Text);
            su = Convert.ToInt32(txtsu.Text);
            cay = Convert.ToInt32(txtcay.Text);
            bilet = Convert.ToInt32(txtbilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lbltoplam.Text = toplam.ToString() + " TL";

            kasatutar = toplam + kasatutar;
            lblkasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();

        }
    }
}
