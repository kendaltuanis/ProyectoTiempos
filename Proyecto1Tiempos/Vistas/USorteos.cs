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
    public partial class USorteos : MetroUserControl
    {
        private SorteoControl osorteo;
        private int rowIndex, colunmIndex;

        public USorteos()
        {
            InitializeComponent();
            this.osorteo = new SorteoControl();
            CargarSorteos();
        }

        private void CargarSorteos() {
            dtgSorteos.DataSource = osorteo.Refrescar();

        }

        private void dtgSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colunmIndex = e.ColumnIndex;
        }

        private void grdSorteos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int id;

            if (dtgSorteos.Rows[rowIndex].Cells[0].Value != null)
            {
                id = Convert.ToInt32(dtgSorteos.Rows[rowIndex].Cells[0].Value);
                String nombre = dtgSorteos.Rows[rowIndex].Cells[1].Value.ToString();
                String descripcion = dtgSorteos.Rows[rowIndex].Cells[2].Value.ToString();
                String fecha = dtgSorteos.Rows[rowIndex].Cells[3].Value.ToString();
                Boolean activo = (dtgSorteos.Rows[rowIndex].Cells[4].Value.ToString().Equals("True") ? true : false);

                osorteo.Editar(nombre, descripcion, Convert.ToDateTime(fecha), activo,id);

            }
        }

    }
}
