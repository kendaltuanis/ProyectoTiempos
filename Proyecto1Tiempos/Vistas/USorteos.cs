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
        private static Boolean admin;

        public USorteos()
        {
            InitializeComponent();
            this.osorteo = new SorteoControl();
            admin = FrmLogin.admin;

            CargarSorteos();
            CargarAdmin();
        }

        private void CargarAdmin() {
            if(FrmLogin.admin){
                dtgSorteos.Columns[4].Visible = true;
                dtgSorteos.ReadOnly = false;
            }
        }

        private void dtgSorteos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colunmIndex = e.ColumnIndex;
        }


        private void CargarSorteos() {

            var query = from p in this.osorteo.Refrescar().AsEnumerable()
                        select new
                        {
                            id = p.Field<int>("id"),
                            nombre = p.Field<string>("nombre"),
                            descripcion = p.Field<string>("descripcion"),
                            fecha = p.Field<DateTime>("fecha_hora"),
                            activo = p.Field<Boolean>("activo")
                        };

            DataTable table;
            using (table = new DataTable())
            {
                // Two columns.
                table.Columns.Add("id", typeof(string));
                table.Columns.Add("nombre", typeof(string));
                table.Columns.Add("descripcion", typeof(string));
                table.Columns.Add("fecha_hora", typeof(string));
                table.Columns.Add("activo", typeof(string));

            }

            foreach (var item in query)
            {
                if (!item.activo)
                {
                    if (admin) {
                        table.Rows.Add(item.id, item.nombre, item.descripcion, item.fecha, item.activo);
                    }
                }
                else {
                        table.Rows.Add(item.id, item.nombre, item.descripcion, item.fecha, item.activo);
                }              
            }
            dtgSorteos.DataSource = table;
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
