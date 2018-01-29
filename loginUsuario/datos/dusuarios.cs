using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUsuario.datos
{
    class dusuarios
    {
        public static SqlDataReader CheckLogin(string usuario, string password)
        {
            SqlDataReader reader = null;
            try
            {


                Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.conexion;
                comando.CommandText = "select id,nombre,usuario,departamento,email,perfil,estatus,sucursal,perfil,celular from usuarios where usuario like @usuario and password like @password";
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                reader = comando.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return reader;
        }
    }
}
