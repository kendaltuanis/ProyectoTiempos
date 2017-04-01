using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;
using System.Data;

namespace Proyecto1Tiempos.Controladores
{
    class DineroControl
    {

        private Dinero odinero;

        public DineroControl()
        {
            this.odinero = new Dinero();
        }

        public DataTable Refrescar(int id = 0)
        {
            return odinero.Refrescar(id);
        }

        public void Editar(int dinero,int id)
        {
            odinero = new Dinero(dinero);
            odinero.Actualizar(id);
        }
    }
}
