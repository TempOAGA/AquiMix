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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            Boolean res = bd.AgregarProducto(tbxNomPlatillo.Text, tbxPrecioPlatillo.Text, rtbxDescripcion.Text);

            if (res)
            {
                MessageBox.Show("Su producto fue agregado con exito!");
            }
            else
            {
                MessageBox.Show("No se logro agregar el producto");
            }

            tbxPrecioPlatillo.Clear();
            tbxPrecioPlatillo.Clear();
            rtbxDescripcion.Clear();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
