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
    public partial class BienvenidaUsuario : Form
    {
        public string user;

        public BienvenidaUsuario()
        {
            InitializeComponent();
            labelUsuario.Text = BaseDeDatos.nombreCompleto;
               
            if(BaseDeDatos.tipoUsuario == "Administrador")
            {
                Admingbx.Show();
                Cajerogbx.Hide();
                Gerentegbx.Hide();
            }
            else if(BaseDeDatos.tipoUsuario == "Gerente")
            {
                Admingbx.Hide();
                Cajerogbx.Hide();
                Gerentegbx.Show();
            }
            else if(BaseDeDatos.tipoUsuario == "Cajero")
            {
                Admingbx.Hide();
                Cajerogbx.Show();
                Gerentegbx.Hide();
            }
        }

        private void BienvenidaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void BienvenidaUsuario_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            user = login.Usuario;
        }

        private void Inventariobtn_Click(object sender, EventArgs e)
        {
            inventario inv = new inventario();
            inv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
