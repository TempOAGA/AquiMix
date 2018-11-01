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
            if(user == "Admin")
            {
                //Admingbx.Show();
                Admingbx.Visible = true;
                //Gerentegbx.Hide();
                //Cajerogbx.Hide();
                Gerentegbx.Visible = false;
                Cajerogbx.Visible = false;
            }else if(user == "Gerente")
            {
                Admingbx.Visible = false;
                Gerentegbx.Visible = true;
                Cajerogbx.Visible = false;
            }else if(user == "Cajero")
            {
                Admingbx.Visible = false;
                Gerentegbx.Visible = false;
                Cajerogbx.Visible = true;
            }
            /*
                switch (user)
                {
                    case "Admin":
                        Admingbx.Visible = true;
                        Gerentegbx.Visible = false;
                        Cajerogbx.Visible = false;
                        break;
                    case "Gerente":
                        Admingbx.Visible = false;
                        Gerentegbx.Visible = true;
                        Cajerogbx.Visible = false;
                        break;
                    case "Cajero":
                        Admingbx.Visible = false;
                        Gerentegbx.Visible = false;
                        Cajerogbx.Visible = true;
                        break;
                    default:
                        break;
                }*/
            /*   
            if(BaseDeDatos.tipoUsuario == "Administrador")
            {
                panelAdministrador.Visible = true;
                panelCajero.Visible = false;
                panelGerente.Visible = false;
            }
            else if(BaseDeDatos.tipoUsuario == "Gerente")
            {
                panelAdministrador.Visible = false;
                panelCajero.Visible = false;
                panelGerente.Visible = true;
            }
            else if(BaseDeDatos.tipoUsuario == "Cajero")
            {
                panelAdministrador.Visible = false;
                panelCajero.Visible = true;
                panelGerente.Visible = false;
            }*/
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
    }
}
