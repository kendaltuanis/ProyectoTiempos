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

        public UGanadores()
        {
            InitializeComponent();
            osorteocontrol = new SorteoControl();
            ComboBoxs.Sorteos(cmbSorteos);
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            
        }


    }
}
