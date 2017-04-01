using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using Proyecto1Tiempos.Controladores;
using Proyecto1Tiempos.Utils;


namespace Proyecto1Tiempos.Vistas
{
    public partial class UApuestas : MetroUserControl
    {
       private SorteoControl osorteocontrol;
       private ApuestaControl oapuestacontrol;

        public UApuestas()
        {
            InitializeComponent();
            CrearBotonesNumeros();
            osorteocontrol = new SorteoControl();
            this.oapuestacontrol = new ApuestaControl();

            ComboBoxs.Sorteos(cmbSorteo);
        }

        private void CrearBotonesNumeros() {
            Button btn;
            int x=3, y=3;
            int numeros=0;
            for (int i = 0; i < 10; i++)
            {
                x = 21;
                for (int j = 0; j < 10; j++)
                {
                    btn = new Button();
                    int name = numeros;
                    btn.Text = name.ToString();
                    btn.Size = new Size(35, 35);
                    btn.Location = new Point(x, y);
                    btn.Tag = i.ToString();
                    int a = i;
                    pnlBotones.Controls.Add(btn);
                    btn.Click += new EventHandler(this.btn_Click);
                    x = x + 35;
                    numeros++;
                }
                y = y + 35;
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            lblNumero.Text = btn.Text;
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            Apostar();
        }

        private void Apostar() {

            oapuestacontrol.Insertar(FrmLogin.id,Convert.ToInt32(cmbSorteo.SelectedValue), Convert.ToInt32(lblNumero.Text), Convert.ToInt32(txtMonto.Text));
            if (Program.connection.isError) {
                Messages.MensajeMediano(this, "Apuesta no permitida", Program.connection.errorDescription);
                return;
            }

            rtxtApuestas.AppendText(string.Format("Numero: {0} Apuesta: {1}", lblNumero.Text, txtMonto.Text)+"\n" ) ;

            txtMonto.Clear();
            lblNumero.Text = "";

            
        }
    }
}
