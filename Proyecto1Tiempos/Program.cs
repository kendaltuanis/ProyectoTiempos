using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1Tiempos.Vistas;
using System.Configuration;
using DBAccess;

namespace Proyecto1Tiempos
{
   public static class Program
    {
        public static DBAccess.DBAccess connection;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = ConfigurationManager.ConnectionStrings["Pg"].ConnectionString;
            Program.connection = new PgAccess(connectionString);

            Application.Run(new FrmLogin());
        }
    }
}
