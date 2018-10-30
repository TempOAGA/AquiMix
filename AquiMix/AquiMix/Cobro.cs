using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AquiMix
{
    public partial class Cobro : Form
    {
        public Cobro()
        {
            InitializeComponent();
            //Totaltbx.Text = "200";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int MetodoCobrar(int a, int b)
        {
            int c = 0;
            c = a - b;          
            return c;
        }

        private void Dinerotbx_TextChanged(object sender, EventArgs e)
        {
            int c = MetodoCobrar(Convert.ToInt32(Totaltbx.Text.ToString()), Convert.ToInt32(Dinerotbx.Text.ToString()));
            Cambiotbx.Text = c.ToString();
        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Totaltbx.Text = menu.Total;
        }
    }
}
