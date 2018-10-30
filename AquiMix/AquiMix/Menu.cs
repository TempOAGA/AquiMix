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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Hotdoglbl.Text = Csencillo.ToString();
            HDJumbolbl.Text = CJumbo.ToString();
            HTDoblelbl.Text = CDoble.ToString();
            Papaslbl.Text = CPapas.ToString();
            ChileTocinolbl.Text = CChile.ToString();
            Sodalbl.Text = CSoda.ToString();
        }

        public static int Csencillo = 0;
        public static int CDoble = 0;
        public static int CJumbo = 0;
        public static int CPapas = 0;
        public static int CChile = 0;
        public static int CSoda = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Csencillo++;
            Hotdoglbl.Text = Csencillo.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Csencillo <= 0)
            {
                Csencillo = 0;
            }
            else
            {
                Csencillo--;
                Hotdoglbl.Text = Csencillo.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CDoble++;
            HTDoblelbl.Text = CDoble.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(CDoble <= 0)
            {
                CDoble = 0;
            }
            else
            {
                CDoble--;
                HTDoblelbl.Text = CDoble.ToString();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CJumbo++;
            HDJumbolbl.Text = CJumbo.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(CJumbo <= 0)
            {
                CJumbo = 0;
            }
            else
            {
                CJumbo++;
                HDJumbolbl.Text = CJumbo.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CPapas++;
            Papaslbl.Text = CPapas.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(CPapas <= 0)
            {
                CPapas = 0;
            }
            else
            {
                CPapas--;
                Papaslbl.Text = CPapas.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CChile++;
            ChileTocinolbl.Text = CChile.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(CChile <= 0)
            {
                CChile = 0;
                ChileTocinolbl.Text = CChile.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CSoda++;
            Sodalbl.Text = CSoda.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (CSoda <= 0)
            {
                CSoda = 0;
            }
            else
            {
                CSoda--;
                Sodalbl.Text = CSoda.ToString();
            }
        }

        private void Pagarbtn_Click(object sender, EventArgs e)
        {
            Cobro cobro = new Cobro();
            cobro.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Csencillo = 0;
            CDoble = 0;
            CJumbo = 0;
            CPapas = 0;
            CChile = 0;
            CSoda = 0;

            Hotdoglbl.Text = "0";
            HDJumbolbl.Text = "0";
            HTDoblelbl.Text = "0";
            Papaslbl.Text = "0";
            ChileTocinolbl.Text = "0";
            Sodalbl.Text = "0";

            ListaOrdenrtbx.Clear();
        }

    }
}
