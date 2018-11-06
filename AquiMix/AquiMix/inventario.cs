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
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }

        private void Bienvenidabtn_Click(object sender, EventArgs e)
        {
            BienvenidaUsuario bienvenida = new BienvenidaUsuario();
            bienvenida.Show();
            this.Close();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aquiMixDataSet.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.aquiMixDataSet.Menu);
            // TODO: esta línea de código carga datos en la tabla 'aquiMixDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.aquiMixDataSet.Inventario);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProducto update = new UpdateProducto();
            update.Show();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminar = new EliminarProducto();
            eliminar.Show();
        }
    }
}
