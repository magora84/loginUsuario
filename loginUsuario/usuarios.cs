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
    class Usuarios
    {
        #region atributos
                private int id;
                private String usuario;
                private string password;
                private string nombre;
                private string departamento;
                private string celular;
                private string estatus;
                private string email;
                private string sucursal;
                private DateTime fecha_creacion;
                private DateTime fecha_actualizacion;
                private string perfil;
        #endregion

        public static Usuarios CheckLogin(string usuario,string password)
        {

            Usuarios oUsuario = new Usuarios();
            SqlDataReader reader = dusuarios.CheckLogin(usuario, password);
            if (reader.HasRows)
            {

                
                reader.Read();
                if(reader[0] != DBNull.Value) oUsuario.Id = Convert.ToInt32(reader[0]);
                if (reader[1] != DBNull.Value) oUsuario.Nombre = Convert.ToString(reader[1]);
                if (reader[2] != DBNull.Value) oUsuario.Usuario = Convert.ToString(reader[2]);
                if (reader[3] != DBNull.Value) oUsuario.Departamento = Convert.ToString(reader[3]);
                if (reader[4] != DBNull.Value) oUsuario.Email = Convert.ToString(reader[4]);
                if (reader[5] != DBNull.Value) oUsuario.Perfil = Convert.ToString(reader[5]);
                if (reader[6] != DBNull.Value) oUsuario.Celular = Convert.ToString(reader[6]);

            }
            else { oUsuario = null; }

            reader.Close();
            return oUsuario;



        }


        #region propiedades
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Celular { get; set; }
        public string Estatus { get; set; }
        public string Email { get; set; }
        public string Sucursal { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Fecha_actualizacion { get; set; }
        public string Perfil { get; set; }
        #endregion
    }
}
