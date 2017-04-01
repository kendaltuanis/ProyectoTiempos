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

namespace Proyecto1Tiempos.Vistas
{
    public partial class UGanancia : MetroUserControl
    {
        private GananciasControl ogananciascontrol;

        public UGanancia()
        {
            InitializeComponent();
            this.ogananciascontrol = new GananciasControl();
            CargarGanancias();
        }

        private void CargarGanancias() {
            this.dtgGanancias.DataSource = ogananciascontrol.Refrescar();
        }
    }
}
