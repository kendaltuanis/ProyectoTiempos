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
    public partial class UNuevoSorteo : MetroUserControl
    {
        private SorteoControl osorteo;

        public UNuevoSorteo()
        {
            InitializeComponent();
            this.osorteo = new SorteoControl();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            osorteo.Insertar(txtNombre.Text, txtDescripcion.Text, (Convert.ToDateTime(txtFecha.Text)));
        }
    }
}
