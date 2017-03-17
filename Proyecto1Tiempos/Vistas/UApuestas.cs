using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Proyecto1Tiempos.Vistas
{
    public partial class UApuestas : MetroUserControl
    {
        public UApuestas()
        {
            InitializeComponent();
            CrearBotonesNumeros();
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
                 //   btn.Text = i.ToString();
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
