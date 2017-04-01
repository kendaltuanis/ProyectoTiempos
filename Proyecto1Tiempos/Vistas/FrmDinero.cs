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
using Proyecto1Tiempos.Controladores;
using Proyecto1Tiempos.Utils;

namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmDinero : MetroForm
    {
        private DineroControl oDineroControl;
        private int id;
        private const string aviso = "Dinero actualizado";
        private const string title = "Dinero";

        public FrmDinero()
        {
            InitializeComponent();
            this.oDineroControl = new DineroControl();
            CargarDinero();
        }

        private void CargarDinero() {
            DataTable dt = oDineroControl.Refrescar();
           txtDinero.Text= dt.AsEnumerable().Select(i => i.Field<Int32>("dinero_caja")).First().ToString();
           id = dt.AsEnumerable().Select(i => i.Field<Int32>("id")).First();
        }

       
    private void txtDinero_KeyUp(object sender, KeyEventArgs e)
        {

            MetroTextBox textBox1 = new MetroTextBox();

            try {
                Console.WriteLine(textBox1.Text = string.Format("{0:#,##0.00}", double.Parse(textBox1.Text)));
            }

            catch (Exception es) {

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarDinero();
        }

        private void ActualizarDinero() {
            oDineroControl.Editar(Convert.ToInt32(txtDinero.Text), id);
            if (Program.connection.isError)
            {
                Console.WriteLine(Program.connection.errorDescription);
                return;
            }
            Messages.MensajePequeno(this, aviso);
        }

        private void txtDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                ActualizarDinero();
            }
        }
    }
}
