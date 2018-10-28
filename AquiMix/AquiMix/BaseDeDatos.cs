using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AquiMix
{
    class BaseDeDatos
    {
        private string cadenaConexion = "Data Source=LAPTOP-F6H1TLU1/SQLEXPRESS;Initial Catalog=AquiMix;Integrated Security=True";

        public static string nombreCompleto = "";
        public static string tipoUsuario = "";

        public Boolean InicioSesion(string nomus, string con)
        {
            nombreCompleto = "";
            tipoUsuario = "";

            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();

            SqlParameter parnomus = new SqlParameter("@normus", nomus);
            SqlParameter parcon = new SqlParameter("@con", con);

            SqlCommand comando = new SqlCommand("select Nombre, Apellido, nivel from Credenciales where usuario = @nomus and psswd collate Latin1_General_CS_AS = @con", connection);
            comando.Parameters.Add(parnomus);
            comando.Parameters.Add(parcon);

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                nombreCompleto = lector.GetString(0) + "" + lector.GetString(1);
                tipoUsuario = lector.GetString(3);
            }

            lector.Close();
            connection.Close();

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
