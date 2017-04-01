using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Proyecto1Tiempos.Controladores;
using System.Threading;

namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmLogin : MetroForm
    {
        private UsuarioControl usuarioControl;
        public static int id;
        public static Boolean admin;
        private const string error = "Usuario o contraseña incorrecta";

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
            if(ofrmAgregarusuario.Open())
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
                    if (item.admin) {
                        admin = true;
                    }

                    IniciarSesion();
                    return;
                }

                usuario = false;   clave = false;
            }

            new Thread(MessageError).Start();          
        }

        private void MessageError() {
            
            this.Invoke((MethodInvoker)delegate {
                MetroFramework.MetroMessageBox.Show(this, error, "Error", 100);
            });
            
        }

        private void IniciarSesion() {
            FrmMenu menu = new FrmMenu();
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
