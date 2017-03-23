using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1Tiempos.Modelos;
using DBAccess;

namespace Proyecto1Tiempos.Controladores
{
    class UsuariosControl : ErrorHandler
    {
        private Usuarios ousuarios;

        public UsuariosControl()
        {
           this.ousuarios = new Usuarios();
        }

        public DataTable Refrescar() {
           return ousuarios.Refrescar();
        }

        public void Insertar(String nombre, String correo, String usuario, String clave) {
            ousuarios = new Usuarios(nombre, correo, usuario, clave);
            ousuarios.Insertar();
        }
    }
}
