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

            try
            {
                conx.Open();
                MessageBox.Show("Se logro");
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro");
            }
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
    }
}
