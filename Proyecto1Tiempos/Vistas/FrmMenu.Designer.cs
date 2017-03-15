using System;

namespace Proyecto1Tiempos.Vistas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.linkOpciones = new MetroFramework.Controls.MetroLink();
            this.contextMenuOpciones = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.UResultados = new MetroFramework.Controls.MetroTile();
            this.USorteos = new MetroFramework.Controls.MetroTile();
            this.UApuestas = new MetroFramework.Controls.MetroTile();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlBackMenu = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitulo = new MetroFramework.Controls.MetroPanel();
            this.contextMenuOpciones.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBackMenu.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkOpciones
            // 
            this.linkOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkOpciones.Image = global::Proyecto1Tiempos.Properties.Resources.configuratition_focus;
            this.linkOpciones.ImageSize = 35;
            this.linkOpciones.Location = new System.Drawing.Point(543, 41);
            this.linkOpciones.Name = "linkOpciones";
            this.linkOpciones.NoFocusImage = global::Proyecto1Tiempos.Properties.Resources.configuratition_no_focus;
            this.linkOpciones.Size = new System.Drawing.Size(49, 36);
            this.linkOpciones.TabIndex = 0;
            this.linkOpciones.UseSelectable = true;
            this.linkOpciones.Click += new System.EventHandler(this.linkOpciones_Click);
            // 
            // contextMenuOpciones
            // 
            this.contextMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.ganadoresToolStripMenuItem});
            this.contextMenuOpciones.Name = "contextMenuOpciones";
            this.contextMenuOpciones.Size = new System.Drawing.Size(162, 48);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteosToolStripMenuItem,
            this.dineroToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.administrarToolStripMenuItem.Text = "Mantenimientos";
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sorteosToolStripMenuItem.Text = "Sorteos";
            // 
            // dineroToolStripMenuItem
            // 
            this.dineroToolStripMenuItem.Name = "dineroToolStripMenuItem";
            this.dineroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dineroToolStripMenuItem.Text = "Dinero";
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ganadoresToolStripMenuItem.Text = "Ganadores";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.UResultados);
            this.pnlMenu.Controls.Add(this.USorteos);
            this.pnlMenu.Controls.Add(this.UApuestas);
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(23, 84);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(569, 348);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // UResultados
            // 
            this.UResultados.ActiveControl = null;
            this.UResultados.BackColor = System.Drawing.Color.LightSteelBlue;
            this.UResultados.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UResultados.Location = new System.Drawing.Point(49, 170);
            this.UResultados.Name = "UResultados";
            this.UResultados.Size = new System.Drawing.Size(232, 102);
            this.UResultados.Style = MetroFramework.MetroColorStyle.Red;
            this.UResultados.TabIndex = 4;
            this.UResultados.Text = "Resultados";
            this.UResultados.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_resultados;
            this.UResultados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UResultados.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UResultados.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.UResultados.UseCustomBackColor = true;
            this.UResultados.UseCustomForeColor = true;
            this.UResultados.UseSelectable = true;
            this.UResultados.UseStyleColors = true;
            this.UResultados.UseTileImage = true;
            this.UResultados.Click += new System.EventHandler(this.button_Click);
            // 
            // USorteos
            // 
            this.USorteos.ActiveControl = null;
            this.USorteos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.USorteos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.USorteos.Location = new System.Drawing.Point(49, 40);
            this.USorteos.Name = "USorteos";
            this.USorteos.Size = new System.Drawing.Size(232, 102);
            this.USorteos.Style = MetroFramework.MetroColorStyle.Red;
            this.USorteos.TabIndex = 5;
            this.USorteos.Text = "Sorteos";
            this.USorteos.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_apuestas;
            this.USorteos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.USorteos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.USorteos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.USorteos.UseCustomBackColor = true;
            this.USorteos.UseCustomForeColor = true;
            this.USorteos.UseSelectable = true;
            this.USorteos.UseStyleColors = true;
            this.USorteos.UseTileImage = true;
            this.USorteos.Click += new System.EventHandler(this.button_Click);
            // 
            // UApuestas
            // 
            this.UApuestas.ActiveControl = null;
            this.UApuestas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.UApuestas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.UApuestas.Location = new System.Drawing.Point(287, 40);
            this.UApuestas.Name = "UApuestas";
            this.UApuestas.Size = new System.Drawing.Size(232, 102);
            this.UApuestas.Style = MetroFramework.MetroColorStyle.Red;
            this.UApuestas.TabIndex = 6;
            this.UApuestas.Text = "Apuestas";
            this.UApuestas.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_sorteos;
            this.UApuestas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UApuestas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UApuestas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.UApuestas.UseCustomBackColor = true;
            this.UApuestas.UseCustomForeColor = true;
            this.UApuestas.UseSelectable = true;
            this.UApuestas.UseStyleColors = true;
            this.UApuestas.UseTileImage = true;
            this.UApuestas.Click += new System.EventHandler(this.button_Click);
            // 
            // linkBack
            // 
            this.linkBack.Image = global::Proyecto1Tiempos.Properties.Resources.icon_back;
            this.linkBack.ImageSize = 40;
            this.linkBack.Location = new System.Drawing.Point(2, 2);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(47, 45);
            this.linkBack.TabIndex = 2;
            this.linkBack.UseSelectable = true;
            this.linkBack.Click += new System.EventHandler(this.linkBack_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(51, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Menu";
            // 
            // pnlBackMenu
            // 
            this.pnlBackMenu.Controls.Add(this.metroLabel1);
            this.pnlBackMenu.Controls.Add(this.linkBack);
            this.pnlBackMenu.HorizontalScrollbarBarColor = true;
            this.pnlBackMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackMenu.HorizontalScrollbarSize = 10;
            this.pnlBackMenu.Location = new System.Drawing.Point(23, 33);
            this.pnlBackMenu.Name = "pnlBackMenu";
            this.pnlBackMenu.Size = new System.Drawing.Size(114, 48);
            this.pnlBackMenu.TabIndex = 4;
            this.pnlBackMenu.VerticalScrollbarBarColor = true;
            this.pnlBackMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackMenu.VerticalScrollbarSize = 10;
            this.pnlBackMenu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiempos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "________________________________________________";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.HorizontalScrollbarBarColor = true;
            this.pnlTitulo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTitulo.HorizontalScrollbarSize = 10;
            this.pnlTitulo.Location = new System.Drawing.Point(163, 34);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(298, 46);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.VerticalScrollbarBarColor = true;
            this.pnlTitulo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTitulo.VerticalScrollbarSize = 10;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 455);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.linkOpciones);
            this.Controls.Add(this.pnlBackMenu);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 455);
            this.MinimumSize = new System.Drawing.Size(615, 455);
            this.Name = "FrmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.contextMenuOpciones.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlBackMenu.ResumeLayout(false);
            this.pnlBackMenu.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink linkOpciones;
        private MetroFramework.Controls.MetroContextMenu contextMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dineroToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel pnlMenu;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlBackMenu;
        private MetroFramework.Controls.MetroTile UResultados;
        private MetroFramework.Controls.MetroTile USorteos;
        private MetroFramework.Controls.MetroTile UApuestas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel pnlTitulo;
    }
}