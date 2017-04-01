using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;
using System.Data;

namespace Proyecto1Tiempos.Controladores
{
    class GanadoresControl
    {
        private Ganadores oganadores;

        public GanadoresControl()
        {
            this.oganadores = new Ganadores();
        }

        public void Insertar(int id_sorteo, int primer, int segundo, int tercero)
        {
            oganadores = new Ganadores(id_sorteo,primer,segundo,tercero);
            oganadores.Insertar();
        }

    }
}
