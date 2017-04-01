using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Proyecto1Tiempos.Controladores;

namespace Proyecto1Tiempos.Vistas
{
    public partial class UResultados : MetroUserControl
    {

        public UResultados()
        {
            InitializeComponent();
            CargarResultados();
        }

        private void CargarResultados() {
            ResultadosControl oresultadoscontrol = new ResultadosControl();
            dtgResultados.DataSource = oresultadoscontrol.Refrescar(FrmLogin.id);
        }    
         
    }
}
