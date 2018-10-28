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
        public BienvenidaUsuario()
        {
            InitializeComponent();
            labelUsuario.Text = BaseDeDatos.nombreCompleto;

            /*string tp = BaseDeDatos.tipoUsuario.ToString();

            switch (tp)
            {
                case "Administrador":
                    panelAdministrador.Visible = true;
                    panelCajero.Visible = false;
                    panelGerente.Visible = false;
                    break;
                case "Gerente":
                    panelAdministrador.Visible = false;
                    panelCajero.Visible = false;
                    panelGerente.Visible = true;
                    break;
                case "Cajero":
                    panelAdministrador.Visible = false;
                    panelCajero.Visible = true;
                    panelGerente.Visible = false;
                    break;
            }*/
                
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
            }
        }

        private void BienvenidaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
