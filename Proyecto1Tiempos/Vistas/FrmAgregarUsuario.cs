using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Proyecto1Tiempos.Controladores;
using System.Text.RegularExpressions;

namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmAgregarUsuario : MetroForm
    {
        private UsuarioControl usuarioControl;
        private Boolean formatEmailConfirmed=false;
        private Boolean open = false;

        public FrmAgregarUsuario()
        {
            InitializeComponent();
            this.usuarioControl = new UsuarioControl();
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

            FrmLogin.SetId(this.usuarioControl.Insertar(txtNombre.Text, txtCorreo.Text, txtUsuario.Text, myHash)); 

            if (usuarioControl.isError) {
                Console.WriteLine(usuarioControl.errorDescription);
                return;
            }
            open = true;
            this.Close();
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarUsuario();
            }
        }

        private void txtFieldsTextChanged(object sender, EventArgs e)
        {
            MetroTextBox textBox = sender as MetroTextBox;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                epError.SetError(textBox, "Campo necesario");
                btnRegistrar.Enabled = ValidarTodos();
                return;
            }
            epError.Clear();
            btnRegistrar.Enabled = ValidarTodos();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            String texto = txtCorreo.Text;

            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(texto, expresion))
            {
                if (Regex.Replace(texto, expresion, String.Empty).Length == 0)
                {
                    epError.Clear();
                    formatEmailConfirmed = true;
                    btnRegistrar.Enabled = ValidarTodos();
                }
                else
                {
                    epError.SetError(txtCorreo, "Formato incorrecto");
                    txtCorreo.Focus();                  
                    btnRegistrar.Enabled = false;
                    formatEmailConfirmed = false;
                }
            }
            else
            {
                epError.SetError(txtCorreo, "Formato incorrecto");
                btnRegistrar.Enabled = false;
                formatEmailConfirmed = false;
            }
        }


        private Boolean ValidarTodos() {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text)
                || !formatEmailConfirmed ) {
                return false;
            }
            return true;
        }

        public Boolean Open() {

            return open;
        }
    }
}
