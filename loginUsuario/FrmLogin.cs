using loginUsuario.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUsuario
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string usuario = txtUser.Text;

            if (password == "" || usuario == "")
            {
                MessageBox.Show("por favor introduscalos 2 valores");
                txtPassword.Focus();
                return;
            }
            else
            {
                Usuarios existe = Usuarios.CheckLogin(usuario, password);
                if (existe != null)
                {
                    MessageBox.Show(existe.Nombre);
                }
                else
                {
                    MessageBox.Show("no existe");
                }
            }
        }
    }
}
