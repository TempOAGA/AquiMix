using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AquiMix
{
    public partial class Login : Form
    {
        private string usuario;

        public string Usuario { get => usuario; set => usuario = value; }

        public Login()
        {
            InitializeComponent();
        } 

        private void ShowPsswdckbx_CheckedChanged(object sender, EventArgs e)
        {
            
            switch(ShowPsswdckbx.CheckState)
            {
                case CheckState.Checked:
                    Contrasenatxtbx.UseSystemPasswordChar = false;
                    break;
                case CheckState.Unchecked:
                    Contrasenatxtbx.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Contrasenatxtbx.UseSystemPasswordChar = true; 
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Usuariotxtbx.Text) && !String.IsNullOrEmpty(Contrasenatxtbx.Text))
            {
                BienvenidaUsuario bienvenida = new BienvenidaUsuario();
                bienvenida.Show();
                this.Hide();
                /*try
                {
                    BaseDeDatos bd = new BaseDeDatos();

                    Boolean res = bd.InicioSesion(Usuariotxtbx.Text.ToString(), Contrasenatxtbx.Text.ToString());

                    if (res)
                    {
                        MessageBox.Show("Exito");
                        BienvenidaUsuario bienvenidaUsuario = new BienvenidaUsuario();
                        bienvenidaUsuario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }*/
            }
            else
            {
                MessageBox.Show("Complete los datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string conexion = "Data Source=LAPTOP-F6H1TLU1/SQLEXPRESS;Initial Catalog=AquiMix;Persist Security Info=True;User ID=sa;Password=ith123";
            SqlConnection cnn = new SqlConnection(conexion);
            try
            {
                cnn.Open();
                MessageBox.Show("Se abrio conexion");
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la conexion");
            }*/
        }

        private void Usuariotxtbx_TextChanged(object sender, EventArgs e)
        {
            Usuario = Usuariotxtbx.Text;
        }
    }
}
