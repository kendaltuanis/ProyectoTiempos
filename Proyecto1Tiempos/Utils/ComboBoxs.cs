using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Controladores;
using System.Data;
using MetroFramework.Controls;
using System.Collections;
using System.ComponentModel;

namespace Proyecto1Tiempos.Utils
{
    public class ComboBoxs
    {
        static SorteoControl osorteocontrol;

        public static void Sorteos(MetroComboBox cmbSorteos,Boolean inactivo =false)
        {
            osorteocontrol = new SorteoControl();

            cmbSorteos.DisplayMember = "nombre";
            cmbSorteos.ValueMember = "id";

            var query = from p in osorteocontrol.Refrescar().AsEnumerable()
                        where p.Field<Boolean>("activo")==true
                        where p.Field<Boolean>("activo")!= inactivo
                        select new { id = p.Field<int>("id"), nombre = p.Field<string>("nombre") };

            cmbSorteos.DataSource = query.Select(i => i).ToList(); 

        }

    }
}
