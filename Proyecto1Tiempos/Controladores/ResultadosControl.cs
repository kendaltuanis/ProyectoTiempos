using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;
using System.Data;

namespace Proyecto1Tiempos.Controladores
{
    class ResultadosControl
    {
        public DataTable Refrescar(int id) {
            Resultados oresultados = new Resultados(id);
            return oresultados.Refrescar();
        }
    }
}
