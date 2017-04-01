using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using HelpersSQL;

namespace Proyecto1Tiempos.Modelos
{
    class Apuesta : ErrorHandler
    {
        private int id_usuario, id_sorteo, numero, monto;

        private SqlHelper sqlHelper;
        private const string nombre_tabla = "apuestas";

        public Apuesta()
        {
            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public Apuesta(int id_usuario,int id_sorteo,int numero,int monto)
        {
            this.id_usuario = id_usuario;
            this.id_sorteo = id_sorteo;
            this.numero = numero;
            this.monto = monto;

            this.sqlHelper = new SqlHelper(nombre_tabla);
        }

        public void Insertar()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("id_usuario", this.id_usuario);
            parametros.Add("id_sorteo", this.id_sorteo);
            parametros.Add("numero", this.numero);
            parametros.Add("monto", this.monto);


            Program.connection.SqlStatement(sqlHelper.InsertSql(parametros.Select(i => i.Key).ToArray()), parametros);

            if (Program.connection.isError)
            {
                this.isError = true;
                this.errorDescription = Program.connection.errorDescription;
            }

        }

    }
}
