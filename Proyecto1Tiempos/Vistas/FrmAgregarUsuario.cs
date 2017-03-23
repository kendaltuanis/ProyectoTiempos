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
using BCrypt.Net;
using Proyecto1Tiempos.Controladores;


namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmAgregarUsuario : MetroForm
    {
        private UsuariosControl usuarioControl;

        public FrmAgregarUsuario()
        {
            InitializeComponent();
            this.usuarioControl = new UsuariosControl();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        private void AgregarUsuario()
        {
            string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            string clave = this.txtClave.Text;

            string myHash = BCrypt.Net.BCrypt.HashPassword(clave, mySalt);

            this.usuarioControl.Insertar(txtNombre.Text, txtCorreo.Text, txtUsuario.Text, myHash);

            if (usuarioControl.isError) {
                Console.WriteLine(usuarioControl.errorDescription);
            }
        }
    }
}
