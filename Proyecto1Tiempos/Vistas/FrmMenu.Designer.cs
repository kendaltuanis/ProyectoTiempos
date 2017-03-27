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
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.tileResultados = new MetroFramework.Controls.MetroTile();
            this.tileSorteos = new MetroFramework.Controls.MetroTile();
            this.tileApuestas = new MetroFramework.Controls.MetroTile();
            this.linkBack = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlBackMenu = new MetroFramework.Controls.MetroPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.linkOpciones.Visible = false;
            this.linkOpciones.Click += new System.EventHandler(this.linkOpciones_Click);
            // 
            // contextMenuOpciones
            // 
            this.contextMenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.ganadoresToolStripMenuItem,
            this.gananciaToolStripMenuItem});
            this.contextMenuOpciones.Name = "contextMenuOpciones";
            this.contextMenuOpciones.Size = new System.Drawing.Size(162, 70);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteosToolStripMenuItem,
            this.gananciasToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.administrarToolStripMenuItem.Text = "Mantenimientos";
            // 
            // sorteosToolStripMenuItem
            // 
            this.sorteosToolStripMenuItem.Name = "sorteosToolStripMenuItem";
            this.sorteosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sorteosToolStripMenuItem.Tag = "UNuevoSorteo";
            this.sorteosToolStripMenuItem.Text = "Nuevo Sorteo";
            this.sorteosToolStripMenuItem.Click += new System.EventHandler(this.ToolStrips_Click);
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.gananciasToolStripMenuItem.Text = "Dinero";
            this.gananciasToolStripMenuItem.Click += new System.EventHandler(this.gananciasToolStripMenuItem_Click);
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ganadoresToolStripMenuItem.Tag = "UGanadores";
            this.ganadoresToolStripMenuItem.Text = "Terminar Sorteo";
            this.ganadoresToolStripMenuItem.Click += new System.EventHandler(this.ToolStrips_Click);
            // 
            // gananciaToolStripMenuItem
            // 
            this.gananciaToolStripMenuItem.Name = "gananciaToolStripMenuItem";
            this.gananciaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.gananciaToolStripMenuItem.Tag = "UGanancia";
            this.gananciaToolStripMenuItem.Text = "Ganancia";
            this.gananciaToolStripMenuItem.Click += new System.EventHandler(this.ToolStrips_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tileResultados);
            this.pnlMenu.Controls.Add(this.tileSorteos);
            this.pnlMenu.Controls.Add(this.tileApuestas);
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(23, 87);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(569, 356);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // tileResultados
            // 
            this.tileResultados.ActiveControl = null;
            this.tileResultados.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tileResultados.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tileResultados.Location = new System.Drawing.Point(51, 170);
            this.tileResultados.Name = "tileResultados";
            this.tileResultados.Size = new System.Drawing.Size(232, 102);
            this.tileResultados.Style = MetroFramework.MetroColorStyle.Red;
            this.tileResultados.TabIndex = 4;
            this.tileResultados.Tag = "UResultados";
            this.tileResultados.Text = "Resultados";
            this.tileResultados.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_resultados;
            this.tileResultados.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileResultados.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileResultados.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileResultados.UseCustomBackColor = true;
            this.tileResultados.UseCustomForeColor = true;
            this.tileResultados.UseSelectable = true;
            this.tileResultados.UseStyleColors = true;
            this.tileResultados.UseTileImage = true;
            this.tileResultados.Click += new System.EventHandler(this.button_Click);
            // 
            // tileSorteos
            // 
            this.tileSorteos.ActiveControl = null;
            this.tileSorteos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tileSorteos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tileSorteos.Location = new System.Drawing.Point(51, 40);
            this.tileSorteos.Name = "tileSorteos";
            this.tileSorteos.Size = new System.Drawing.Size(232, 102);
            this.tileSorteos.Style = MetroFramework.MetroColorStyle.Red;
            this.tileSorteos.TabIndex = 5;
            this.tileSorteos.Tag = "USorteos";
            this.tileSorteos.Text = "Sorteos";
            this.tileSorteos.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_apuestas;
            this.tileSorteos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSorteos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSorteos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileSorteos.UseCustomBackColor = true;
            this.tileSorteos.UseCustomForeColor = true;
            this.tileSorteos.UseSelectable = true;
            this.tileSorteos.UseStyleColors = true;
            this.tileSorteos.UseTileImage = true;
            this.tileSorteos.Click += new System.EventHandler(this.button_Click);
            // 
            // tileApuestas
            // 
            this.tileApuestas.ActiveControl = null;
            this.tileApuestas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tileApuestas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tileApuestas.Location = new System.Drawing.Point(289, 40);
            this.tileApuestas.Name = "tileApuestas";
            this.tileApuestas.Size = new System.Drawing.Size(232, 102);
            this.tileApuestas.Style = MetroFramework.MetroColorStyle.Red;
            this.tileApuestas.TabIndex = 6;
            this.tileApuestas.Tag = "UApuestas";
            this.tileApuestas.Text = "Apuestas";
            this.tileApuestas.TileImage = global::Proyecto1Tiempos.Properties.Resources.tile_sorteos;
            this.tileApuestas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileApuestas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileApuestas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileApuestas.UseCustomBackColor = true;
            this.tileApuestas.UseCustomForeColor = true;
            this.tileApuestas.UseSelectable = true;
            this.tileApuestas.UseStyleColors = true;
            this.tileApuestas.UseTileImage = true;
            this.tileApuestas.Click += new System.EventHandler(this.button_Click);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 36);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Tiempos";
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
            this.pnlTitulo.Controls.Add(this.lblTitulo);
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
        private MetroFramework.Controls.MetroPanel pnlMenu;
        private MetroFramework.Controls.MetroLink linkBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel pnlBackMenu;
        private MetroFramework.Controls.MetroTile tileResultados;
        private MetroFramework.Controls.MetroTile tileSorteos;
        private MetroFramework.Controls.MetroTile tileApuestas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel pnlTitulo;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciaToolStripMenuItem;
    }
}