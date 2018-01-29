using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUsuario.datos
{
   
        public static class Conexion
        {
            public static SqlConnection conexion = new SqlConnection();
            private static string dbSource= "DESKTOP-0BRLGSJ\\SQLEXPRESS ";
            private static string dbUser = "sa";
            private static string dbPass = "TCQOJC";
            private static string db = "cobranza";

            public static void Conectar()
            {
                try
                {
                    conexion = new SqlConnection("Data Source="+ dbSource +";Initial Catalog="+ db +";User ID="+ dbUser + "; password="+ dbPass +";");
                    conexion.Open();
                }
                catch (SqlException e)
                {

                    MessageBox.Show(e.Message);
                }
            }
            public static void Desconectar()
            {
                try
                {
                    if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();

                }
                catch (SqlException e)
                {
                    MessageBox.Show("ocurrio un error en la conexion " + e.Message);
                }
            }
        }
    
}
