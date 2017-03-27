using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace Proyecto1Tiempos.Vistas
{
    public partial class FrmMenu : MetroForm
    {

        private Control[] tiles;
        private String title = "Tiempos";
        private int id = 0;

        public FrmMenu(int id,Boolean admin = false)
        {
            InitializeComponent();
            MenuTiles();
            this.id = id;
            Admin(admin);
        }
        
              
        /*
          Evento 'Click' que se encarga de obtener los controles de un determinado 'MetroUserControl'
          y agregarlos a un panel(pnlMain) en el Frame.

          Este recorre todos los 'MetroUserControl' que hayan en el proyecto.
         */
        protected void button_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            BackPanelVisible();

            MetroTile button = sender as MetroTile;
            BusquedaUser(button.Tag.ToString());
        
        }

        private void Admin(Boolean admin) {
            if (admin)
                linkOpciones.Visible = true;
        }

        private void BusquedaUser(String name) {
  
            this.lblTitulo.Text = name.Substring(1, name.Length - 1);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(MetroUserControl).IsAssignableFrom(p))
                .Where(a => !a.FullName.Equals("MetroFramework.Controls.MetroUserControl"));


            foreach (var imp in types)
            {
                MetroUserControl implementation = (MetroUserControl)Activator.CreateInstance(imp);
                if (implementation.Name.Equals(name))
                {
                    implementation.Dock = DockStyle.Fill;
                    this.pnlMenu.Controls.Add(implementation);
                    return;
                }


                /*var controls = from Control control in this.Controls
                             select control;
                  this.pnlMenu.Controls.AddRange(controls.ToArray());
                /*/
            }
        }

        // Evento 'Click' Se encarga de volver atras y agregar los botones de menu y otros 'controls'
        private void linkBack_Click(object sender, EventArgs e)
        {

            LimpiarControles();

            this.pnlMenu.Controls.AddRange(tiles.Select(c => c).ToArray());

            lblTitulo.Text = title;
            BackPanelVisible(false);

        }

        // Método que se usa para guardar los tiles en un arreglo para luego usarlos cuando se necesite el menú
        private void MenuTiles() {
            tiles = new Control[pnlMenu.Controls.Count];

            int cont = 0;
            foreach (Control item in pnlMenu.Controls)
            {
                tiles[cont] = item;
                cont++;
            }
        }

        // Método que se usa para limpiar los controles del panel 'pnlMain' y dejarlo en blanco
        private void LimpiarControles() {
            this.pnlMenu.Controls.Clear();
        }

        /*
           Método que se encarga de hacer visible o/y invisible el 'backPanel'          
           Por default está en TRUE
        */
        private void BackPanelVisible(bool backMenu = true)
        {
            this.pnlBackMenu.Visible = backMenu;
        }

        // Cierra el form principal o 'FrmLogin' totalmente, porque antes estaba oculto
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Evento 'Click' que se encarga de agregar un contextMenu ya hecho 'contextMenuOpciones' al control link 'linkOpciones'
        private void linkOpciones_Click(object sender, EventArgs e)
        {
            contextMenuOpciones.Show(linkOpciones, new Point(-(linkOpciones.Width), linkOpciones.Height));

        }

        protected void ToolStrips_Click(object sender, EventArgs e) {

            LimpiarControles();
            BackPanelVisible();

            ToolStripMenuItem strip = sender as ToolStripMenuItem;
            BusquedaUser(strip.Tag.ToString());
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDinero ofrmDinero = new FrmDinero();
            ofrmDinero.ShowDialog();
        }
    }
}
