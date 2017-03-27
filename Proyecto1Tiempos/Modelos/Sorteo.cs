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
    class Sorteo : ErrorHandler
    {
        int id;
        String nombre, descripcion;
        DateTime fecha_hora;
        Boolean activo;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "sorteo";

        public Sorteo()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Sorteo(String nombre, String descripcion, DateTime fecha_hora)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_hora = fecha_hora;

            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Sorteo(String nombre, String descripcion, DateTime fecha_hora,Boolean activo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fecha_hora = fecha_hora;
            this.activo = activo;

            this.sqlHelper = new SqlHelper(nombre_tabla);
        }


        public DataTable Refrescar(int id =0) {

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", this.id);
            parametros.Add("nombre", this.nombre);
            parametros.Add("descripcion", this.descripcion);
            parametros.Add("fecha_hora", this.fecha_hora);
            parametros.Add("activo", this.activo);

            String sql;
            if (id > 0) {
                sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray(),new String[] { "id" },new String[] { id.ToString()});
            }

            sql= sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray());

            DataTable result = Program.connection.SqlQuery(sql, parametros);
            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }
            return result;
        }

        public void Insertar() {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            
            parametros.Add("nombre", this.nombre);
            parametros.Add("descripcion", this.descripcion);
            parametros.Add("fecha_hora", this.fecha_hora);

            Program.connection.SqlStatement(sqlHelper.InsertSql(parametros.Select(i => i.Key).ToArray()), parametros);

            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

        }

        public void Actualizar(int id) {

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("nombre", this.nombre);
            parametros.Add("descripcion", this.descripcion);
            parametros.Add("fecha_hora", this.fecha_hora);
            parametros.Add("activo", this.activo);

            string sql = this.sqlHelper.UpdateSql(parametros.Select(i => i.Key).ToArray(), new string[] { "id" });

            parametros.Add("id", id);

            Program.connection.SqlStatement(sql, parametros);

            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

        }

        public void Eliminar() {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);

            Program.connection.SqlStatement(this.sqlHelper.DeleteSql(new string[] { "id" }), parametros);

            if (Program.connection.isError)
                if (Program.connection.isError)
                {
                    this.isError = true;
                    this.errorDescription = Program.connection.errorDescription;
                }

        }

    }
}
