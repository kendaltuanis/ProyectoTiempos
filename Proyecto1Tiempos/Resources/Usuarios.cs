using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using HelpersSQL;
using HelpersSQL.Enums;

namespace Proyecto1Tiempos.Modelos
{
    class Usuarios : ErrorHandler
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "usuario";

        public Usuarios()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Usuarios(String nombre,String correo,String usuario,String clave)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.usuario = usuario;
            this.clave = clave;

            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public DataTable Refrescar() {

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id",this.id);
            parametros.Add("nombre_completo", this.nombre);
            parametros.Add("usuario", this.usuario);
            parametros.Add("clave", this.clave);
            parametros.Add("correo", this.correo);

            String sql = sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray());

            DataTable result = Program.connection.SqlQuery(sql, parametros);
            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }
            return result;

        }

        public int Insertar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre_completo", this.nombre);
            parametros.Add("correo", this.correo);
            parametros.Add("usuario", this.usuario);
            parametros.Add("clave", this.clave);

           int id= Convert.ToInt32(Program.connection.SqlScalar(sqlHelper.InsertSql(parametros.Select(i => i.Key).ToArray(),DBMotor.Postgresql,new String[] {"id"}), parametros));
            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

            return id;
        }

    }
}
