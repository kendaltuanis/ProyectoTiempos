using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;
using System.Data;

namespace Proyecto1Tiempos.Controladores
{
    class SorteoControl
    {
        private Sorteo osorteo;

        public SorteoControl()
        {
            this.osorteo = new Sorteo();
        }

        public DataTable Refrescar(int id = 0)
        {
            return osorteo.Refrescar(id);
        }

        public void Insertar(String nombre, String descripcion, DateTime fecha_hora)
        {
            osorteo = new Sorteo(nombre, descripcion, fecha_hora);
            osorteo.Insertar();
        }

        public void Editar(String nombre, String descripcion, DateTime fecha_hora, Boolean activo,int id) {
            osorteo = new Sorteo(nombre, descripcion, fecha_hora,activo);
            osorteo.Actualizar(id);
        }

    }
}
