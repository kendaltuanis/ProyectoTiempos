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
    class UsuarioControl : ErrorHandler
    {
        private Usuario ousuarios;

        public UsuarioControl()
        {
           this.ousuarios = new Usuario();
        }

        public DataTable Refrescar() {
           return ousuarios.Refrescar();
        }

        public int Insertar(String nombre, String correo, String usuario, String clave) {
            ousuarios = new Usuario(nombre, correo, usuario, clave);
            return ousuarios.Insertar();
        }
    }
}
