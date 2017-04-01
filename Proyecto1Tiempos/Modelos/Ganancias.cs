using System;
using System.Collections.Generic;
using System.Linq;
using DBAccess;
using HelpersSQL;
using System.Data;

namespace Proyecto1Tiempos.Modelos
{
    class Ganancias : ErrorHandler
    {
        int ganancia_minima, ganancia_maxima;
        string nombre;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "ganancias";
        private const Boolean isFunction = true;

        public Ganancias()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla, isFunction);
        }

        public DataTable Refrescar(int id = 0)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", this.nombre);
            parametros.Add("ganancia_minima", this.ganancia_minima);
            parametros.Add("ganancia_maxima", this.ganancia_maxima);

            String sql = sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray());

            DataTable result = Program.connection.SqlQuery(sql, parametros);
            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }
            return result;
        }
    }
}
