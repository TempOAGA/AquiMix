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
    public partial class EliminarProducto : Form
    {
        public string id;
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aquiMixDataSet.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.aquiMixDataSet.Menu);

        }

        public Boolean Fill(string id)
        {
            try
            {
                string cadenaConexion = @"Data Source=LAPTOP-F6H1TLU1\SQLEXPRESS;Initial Catalog=AquiMix;Persist Security Info=True;User ID=sa;Password=ith123";

                SqlConnection conx = new SqlConnection(cadenaConexion);
                conx.Open();

                string query = "SELECT [precio], [descripcion] FROM " +
                    "[dbo].[Menu] where idPlatillo =" + id + ";";
                SqlCommand comando = new SqlCommand(query, conx);

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    double c = lector.GetDouble(0);
                    tbxPrecio.Text = c.ToString();
                    tbxDescripcion.Text = lector.GetString(1);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo rellenar tabla.");
                return false;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxEliminar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToString(cbxEliminar.SelectedValue);
                Fill(id);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id = cbxEliminar.SelectedValue.ToString();
            BaseDeDatos bd = new BaseDeDatos();

            Boolean res = bd.EliminarProducto(id);

            if (res)
            {
                MessageBox.Show("Se elimino el producto con exito.");
                tbxPrecio.Clear();
                tbxDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("No se logro eliminar el producto con exito.");
            }
        }
    }
}
