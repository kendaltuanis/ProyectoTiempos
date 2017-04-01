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
using Proyecto1Tiempos.Controladores;
using Proyecto1Tiempos.Utils;

namespace Proyecto1Tiempos.Vistas
{
    public partial class UGanadores : MetroUserControl
    {
        SorteoControl osorteocontrol;
        GanadoresControl oganadorescontrol;

        public UGanadores()
        {
            InitializeComponent();
            osorteocontrol = new SorteoControl();
            oganadorescontrol = new GanadoresControl();
            ComboBoxs.Sorteos(cmbSorteos);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtPrimerNumero.Text = Convert.ToString(rnd.Next(0, 99));
            txtSegundoNumero.Text = Convert.ToString(rnd.Next(0, 99));
            txtTercerNumero.Text = Convert.ToString(rnd.Next(0, 99));
        }

        private void btnTerminarSorteo_Click(object sender, EventArgs e)
        {
            TerminarSorteo();
        }

        private void TerminarSorteo() {
            oganadorescontrol.Insertar(Convert.ToInt32(cmbSorteos.SelectedValue),Convert.ToInt32(txtPrimerNumero.Text), 
                Convert.ToInt32(txtSegundoNumero.Text), Convert.ToInt32(txtTercerNumero.Text));
            if (Program.connection.isError) {
                Console.WriteLine(Program.connection.errorDescription);
                return;
            }

            txtPrimerNumero.Clear();
            txtSegundoNumero.Clear();
            txtTercerNumero.Clear();

        }
    }
}
