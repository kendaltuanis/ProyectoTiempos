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
    class Ganadores : ErrorHandler
    {
        private int id,id_sorteo;
        private int primer_numero,segundo_numero,tercer_numero;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "sorteo_numeros";

        public Ganadores()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Ganadores(int id_sorteo,int primer,int segundo,int tercero)
        {
            this.id_sorteo = id_sorteo;
            this.primer_numero = primer;
            this.segundo_numero = segundo;
            this.tercer_numero = tercero;
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }


        public void Insertar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("id_sorteo", this.id_sorteo);
            parametros.Add("primer_numero", this.primer_numero);
            parametros.Add("segundo_numero", this.segundo_numero);
            parametros.Add("tercer_numero", this.tercer_numero);

            Program.connection.SqlStatement(sqlHelper.InsertSql(parametros.Select(i => i.Key).ToArray()), parametros);

            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

        }
    }
}
