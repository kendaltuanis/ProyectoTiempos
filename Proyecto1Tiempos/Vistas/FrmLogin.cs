using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using BCrypt.Net;
using Proyecto1Tiempos.Controladores;

namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmLogin : MetroForm
    {
        private UsuarioControl usuarioControl;
        static int id;
       
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarioControl = new UsuarioControl();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario ofrmAgregarusuario = new FrmAgregarUsuario();
            ofrmAgregarusuario.ShowDialog();
            IniciarSesion();

        }

        private void Login()
        {
            DataTable dt = this.usuarioControl.Refrescar();
            bool usuario, clave;

            var query = from p in dt.AsEnumerable()
            select new {id = p.Field<int>("id"), user = p.Field<string>("usuario"),
                pass = p.Field<string>("clave"), admin = p.Field<Boolean>("admin")};          

            foreach (var item in query)
                {
                    usuario = (item.user.Equals(txtUsuario.Text) ? true : false);
                    clave = BCrypt.Net.BCrypt.Verify(txtClave.Text, item.pass);

                if (usuario && clave) {
                    id = item.id;

                    IniciarSesion(item.admin);
                    return;
                }

                usuario = false;   clave = false;

            }
        }

        private void IniciarSesion(Boolean admin =false) {
            FrmMenu menu = new FrmMenu(id,admin);
            menu.Show();
            this.Hide();
        }

        public static void SetId(int ide) {
            id = ide;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                Login();
            }      
        }

        // bycript -- hashing -- hace salt key
    }
}
