using Proyecto1Tiempos.Modelos;
using System.Data;

namespace Proyecto1Tiempos.Controladores
{
    class GananciasControl
    {
        public DataTable Refrescar(int id=0) {
            Ganancias oganancias = new Ganancias();
            return oganancias.Refrescar(id);
        }
    }
}
