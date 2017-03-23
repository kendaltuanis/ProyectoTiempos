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
        private UsuariosControl usuarioControl;
       
        public FrmLogin()
        {
            InitializeComponent();
            this.usuarioControl = new UsuariosControl();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();

          //  this.Hide();
           // FrmMenu menu = new FrmMenu();
            //menu.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario oUser = new FrmAgregarUsuario();
            oUser.ShowDialog();
        }

        private void Login() {
            DataTable dt = this.usuarioControl.Refrescar();
            foreach (DataRow row in dt.Rows)
            {            
                foreach (DataColumn col in dt.Columns) {
                    String n = col.ColumnName;
                    if (n.Equals("usuario")) {
                        String value = row[col.ColumnName].ToString();
                        if (value.Equals(txtUsuario.Text)) {
                            Console.WriteLine("Usuario si");
                        }
                    }

                    if (n.Equals("clave"))
                    {
                        String value = row[col.ColumnName].ToString();
                       Boolean verificar= BCrypt.Net.BCrypt.Verify(txtClave.Text, value);

                        if (verificar)
                        {
                            Console.WriteLine("Contraseña si");
                        }
                    }
                }
            }
            /*
            DataColumn colN = dt.Columns["nombre_completo"];
            DataColumn colC = dt.Columns["clave"];
            for (int i = 0; i < colN.Colu; i++)
            {

            }
            */
        }

        


        // bycript -- hashing -- hace salt key
        // 

    }
}
