using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksit_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taksit, tutar;
            double taksitlitutar;

            taksit = tbTaksit.Value;
            tutar = Convert.ToInt32(txtTutar.Text);

            taksitlitutar = (double) tutar / taksit;

            lblTutar.Text ="Taksit Tutarı :" + taksitlitutar.ToString();

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        { 

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTaksit.Text = tbTaksit.Value.ToString();
        }
    }
}
