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
    class Dinero : ErrorHandler
    {
        int id,dinero_caja;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "casa";

        public Dinero()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Dinero(int dinero)
        {
            this.dinero_caja = dinero;
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public DataTable Refrescar(int id = 0)
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", this.id);
            parametros.Add("dinero_caja", this.dinero_caja);

            String sql;
            if (id > 0)
            {
                sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray(), new String[] { "id" }, new String[] { id.ToString() });
            }

            sql = sqlHelper.SelectSql(parametros.Select(i => i.Key).ToArray());

            DataTable result = Program.connection.SqlQuery(sql, parametros);
            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }
            return result;
        }

        public void Actualizar(int id)
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("dinero_caja", this.dinero_caja);

            string sql = this.sqlHelper.UpdateSql(parametros.Select(i => i.Key).ToArray(), new string[] { "id" });

            parametros.Add("id", id);

            Program.connection.SqlStatement(sql, parametros);

            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

        }

    }
}
