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
    public partial class UpdateProducto : Form
    {
        public string id;

        public UpdateProducto()
        {
            InitializeComponent();
        }

    

        private void UpdateProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aquiMixDataSet.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.aquiMixDataSet.Menu);
            string id = cbxMenu.SelectedValue.ToString();
            Fill(id);
        }

        private void CbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string id = cbxMenu.SelectedValue.ToString();
           // Fill(id);
        }

        public Boolean Fill(string id)
        {
            try
            {
                string cadenaConexion = @"Data Source=LAPTOP-F6H1TLU1\SQLEXPRESS;Initial Catalog=AquiMix;Persist Security Info=True;User ID=sa;Password=ith123";

                SqlConnection conx = new SqlConnection(cadenaConexion);
                conx.Open();

                string query = "SELECT [nomPlatillo], [precio], [descripcion] FROM " +
                    "[dbo].[Menu] where idPlatillo =" + id + ";";
                SqlCommand comando = new SqlCommand(query, conx);

                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    tbxPlatillo.Text = lector.GetString(0);
                    double c= lector.GetDouble(1);
                    tbxPrecio.Text = c.ToString();
                    rtbxDescripcion.Text = lector.GetString(2);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo rellenar tabla.");
                return false;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id = cbxMenu.SelectedValue.ToString();
            BaseDeDatos bd = new BaseDeDatos();

            Boolean res = bd.ModificarProducto(tbxPlatillo.Text, tbxPrecio.Text, rtbxDescripcion.Text, id);

            if (res)
            {
                MessageBox.Show("Su producto fue actualizado con exito!");
            }
            else
            {
                MessageBox.Show("No se logro actualizar el producto");
            }
        }

        private void CbxMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToString(cbxMenu.SelectedValue);
                Fill(id);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
