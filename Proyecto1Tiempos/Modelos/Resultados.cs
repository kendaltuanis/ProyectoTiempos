using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using HelpersSQL;
using System.Data;


namespace Proyecto1Tiempos.Modelos
{
    class Resultados : ErrorHandler
    {
        int id,numero, monto_apostado, monto_ganado;
        string nombre;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "resultados";
        private const Boolean isFunction = true;


        public Resultados(int id)
        {
            this.id = id;
            this.sqlHelper = new SqlHelper(string.Format("{0}({1})", nombre_tabla, id));
        }

        public DataTable Refrescar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombres", this.nombre);
            parametros.Add("numeros", this.numero);
            parametros.Add("monto_apostado", this.monto_apostado);
            parametros.Add("monto_ganado", this.monto_ganado);

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
