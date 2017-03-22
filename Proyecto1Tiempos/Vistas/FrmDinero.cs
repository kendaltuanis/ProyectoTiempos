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

namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmDinero : MetroForm
    {
        public FrmDinero()
        {
            InitializeComponent();
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
    }
}
