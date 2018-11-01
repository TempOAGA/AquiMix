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
            Totaltbx.Text = "100";
        }

        //variables
        private string total;
        private static int csencillo = 0;
        private static int cDoble = 0;
        private static int cJumbo = 0;
        private static int cPapas = 0;
        private static int cChile = 0;
        private static int cSoda = 0;
        private static int cSencilloPapas = 0;
        private static int cDoblePapas = 0;
        private static int cJumboPapas = 0;
        private static int Ensalada = 0;
       
        //get set
        public static int Csencillo { get => csencillo; set => csencillo = value; }
        public static int CDoble { get => cDoble; set => cDoble = value; }
        public static int CJumbo { get => cJumbo; set => cJumbo = value; }
        public static int CPapas { get => cPapas; set => cPapas = value; }
        public static int CChile { get => cChile; set => cChile = value; }
        public static int CSoda { get => cSoda; set => cSoda = value; }
        public static int CSencilloPapas { get => cSencilloPapas; set => cSencilloPapas = value; }
        public static int CDoblePapas { get => cDoblePapas; set => cDoblePapas = value; }
        public static int CJumboPapas { get => cJumboPapas; set => cJumboPapas = value; }
        public static int Ensalada1 { get => Ensalada; set => Ensalada = value; }
        public string Total { get => this.total; set => total = value; }

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
                CJumbo--;
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
            }
            else
            {
                CChile--;
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

        private void Totaltbx_TextChanged(object sender, EventArgs e)
        {
            Total = Totaltbx.Text;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
