using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AquiMix
{
    class BaseDeDatos
    {
        private string cadenaConexion = @"Data Source=LAPTOP-F6H1TLU1\SQLEXPRESS;Initial Catalog=AquiMix;Persist Security Info=True;User ID=sa;Password=ith123";

        public static string nombreCompleto = "";
        public static string tipoUsuario = "";

        public Boolean InicioSesion(string nomus, string con)
        {
            nombreCompleto = "";
            tipoUsuario = "";

            SqlConnection conx = new SqlConnection(cadenaConexion);

            conx.Open(); 

            SqlParameter parnomus = new SqlParameter("@nomus", nomus);
            SqlParameter parcon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("select nombre, apellido, rol, direccion, horario, nivel from Usuarios, Credenciales " +
                "where nomUser = @nomus and password collate Latin1_General_CS_AS = @con", conx);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombreCompleto = lector.GetString(0) + " " + lector.GetString(1) + '\t' +
                    "Rol: " + lector.GetString(3) + '\n' + lector.GetString(5);
                tipoUsuario = lector.GetString(5);
            }

            lector.Close();
            conx.Close();
            
            if (String.IsNullOrEmpty(tipoUsuario))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean AgregarProducto(string platillo, string precio, string descripcion)
        {

            SqlConnection conx = new SqlConnection(cadenaConexion);

            conx.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string uno = "INSERT INTO [dbo].[Menu] ([nomPlatillo], [precio], [descripcion]) VALUES(";
            string dos = "'" + platillo + "'" + ",";
            string tres = precio + ",";
            string cuatro = "'" + descripcion + "'";
            string cinco = ")";
            string query = uno + dos + tres + cuatro + cinco;

            command = new SqlCommand(query, conx);

            adapter.InsertCommand = new SqlCommand(query, conx);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();

            conx.Close();

            return true;
        }

        public Boolean ModificarProducto(string platillo, string precio, string descripcion, string id)
        {
                SqlConnection conx = new SqlConnection(cadenaConexion);

                conx.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string uno = "UPDATE [dbo].[Menu] SET[nomPlatillo] = ";
                string dos = "'" + platillo + "'";
                string tres = ", [precio] =" + precio;
                string cuatro = ",[descripcion] =" + "'" + descripcion + "'";
                string cinco = "WHERE idPlatillo = " + id;

                string query = uno + dos + tres + cuatro + cinco;

                command = new SqlCommand(query, conx);

                adapter.UpdateCommand = new SqlCommand(query, conx);
                adapter.UpdateCommand.ExecuteNonQuery();

                command.Dispose();
                conx.Close();

                return true;
        }
        public Boolean EliminarProducto(string id)
        {
            SqlConnection conx = new SqlConnection(cadenaConexion);

            conx.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string query = "DELETE FROM [dbo].[Menu] WHERE idPlatillo =" + id + ";";

            command = new SqlCommand(query, conx);

            adapter.DeleteCommand = new SqlCommand(query, conx);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            conx.Close();

            return true;
        }
    }
}
