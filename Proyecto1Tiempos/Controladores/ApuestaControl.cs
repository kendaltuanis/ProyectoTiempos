using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;

namespace Proyecto1Tiempos.Controladores
{
    class ApuestaControl
    {
        private Apuesta oapuesta;

        public void Insertar(int id_usuario, int id_sorteo, int numero, int monto) {
            this.oapuesta = new Apuesta( id_usuario,  id_sorteo,  numero,  monto);
            this.oapuesta.Insertar();
        }

    }
}
