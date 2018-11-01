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
        private string cadenaConexion = "Data Source=LAPTOP-F6H1TLU1/SQLEXPRESS;Initial Catalog=AquiMix;Persist Security Info=True;User ID=sa;Password=ith123";

        public static string nombreCompleto = "";
        public static string tipoUsuario = "";

        public Boolean InicioSesion(string nomus, string con)
        {
            nombreCompleto = "";
            tipoUsuario = "";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                MessageBox.Show("Se logro");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro");
            }
            conexion.Open();

            SqlParameter parnomus = new SqlParameter("@nomus", nomus);
            SqlParameter parcon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("select Nombre, Apellido, nivel from Credenciales where Usuario = @nomus and psswd collate Latin1_General_CS_AS = @con", conexion);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombreCompleto = lector.GetString(0) + "" + lector.GetString(1);
                tipoUsuario = lector.GetString(2);
            }

            lector.Close();
            conexion.Close();

            if (String.IsNullOrEmpty(tipoUsuario))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
