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
            HDJumbo.Text = CJumbo.ToString();
            HTDoblelbl.Text = CDoble.ToString();
        }

        public static int Csencillo = 0;
        public static int CDoble = 0;
        public static int CJumbo = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Csencillo++;
            Hotdoglbl.Text = Csencillo.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Csencillo--;
            Hotdoglbl.Text = Csencillo.ToString();
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
    }
}
