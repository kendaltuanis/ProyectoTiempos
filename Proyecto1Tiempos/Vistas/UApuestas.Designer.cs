namespace Proyecto1Tiempos.Vistas
{
    partial class UApuestas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotones = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rtxtApuestas = new System.Windows.Forms.RichTextBox();
            this.cmbSorteo = new MetroFramework.Controls.MetroComboBox();
            this.btnApostar = new MetroFramework.Controls.MetroButton();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.pnlBotones.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.metroPanel1);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.HorizontalScrollbarBarColor = true;
            this.pnlBotones.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBotones.HorizontalScrollbarSize = 10;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(569, 348);
            this.pnlBotones.TabIndex = 0;
            this.pnlBotones.VerticalScrollbarBarColor = true;
            this.pnlBotones.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBotones.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.rtxtApuestas);
            this.metroPanel1.Controls.Add(this.cmbSorteo);
            this.metroPanel1.Controls.Add(this.btnApostar);
            this.metroPanel1.Controls.Add(this.txtMonto);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lblNumero);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(384, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(182, 341);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rtxtApuestas
            // 
            this.rtxtApuestas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rtxtApuestas.Location = new System.Drawing.Point(3, 203);
            this.rtxtApuestas.Name = "rtxtApuestas";
            this.rtxtApuestas.Size = new System.Drawing.Size(174, 133);
            this.rtxtApuestas.TabIndex = 7;
            this.rtxtApuestas.Text = "";
            // 
            // cmbSorteo
            // 
            this.cmbSorteo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbSorteo.FormattingEnabled = true;
            this.cmbSorteo.ItemHeight = 19;
            this.cmbSorteo.Location = new System.Drawing.Point(3, 125);
            this.cmbSorteo.Name = "cmbSorteo";
            this.cmbSorteo.PromptText = "Sorteo";
            this.cmbSorteo.Size = new System.Drawing.Size(174, 25);
            this.cmbSorteo.TabIndex = 6;
            this.cmbSorteo.UseSelectable = true;
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(3, 160);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(174, 23);
            this.btnApostar.TabIndex = 5;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseSelectable = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.CustomButton.Image = null;
            this.txtMonto.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtMonto.CustomButton.Name = "";
            this.txtMonto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonto.CustomButton.TabIndex = 1;
            this.txtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonto.CustomButton.UseSelectable = true;
            this.txtMonto.CustomButton.Visible = false;
            this.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMonto.Icon = global::Proyecto1Tiempos.Properties.Resources.icon_money;
            this.txtMonto.IconRight = true;
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(3, 87);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PromptText = "Monto Apostar";
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(174, 29);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.UseSelectable = true;
            this.txtMonto.WaterMark = "Monto Apostar";
            this.txtMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(13, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Número seleccionado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNumero.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumero.Location = new System.Drawing.Point(70, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 0);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UApuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBotones);
            this.Name = "UApuestas";
            this.Size = new System.Drawing.Size(569, 348);
            this.pnlBotones.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBotones;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private MetroFramework.Controls.MetroButton btnApostar;
        private MetroFramework.Controls.MetroComboBox cmbSorteo;
        private System.Windows.Forms.RichTextBox rtxtApuestas;
    }
}
