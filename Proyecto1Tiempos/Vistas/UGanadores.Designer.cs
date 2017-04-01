namespace Proyecto1Tiempos.Vistas
{
    partial class UGanadores
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRandom = new MetroFramework.Controls.MetroButton();
            this.btnTerminarSorteo = new MetroFramework.Controls.MetroButton();
            this.txtTercerNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtSegundoNumero = new MetroFramework.Controls.MetroTextBox();
            this.txtPrimerNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbSorteos = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnRandom);
            this.metroPanel1.Controls.Add(this.btnTerminarSorteo);
            this.metroPanel1.Controls.Add(this.txtTercerNumero);
            this.metroPanel1.Controls.Add(this.txtSegundoNumero);
            this.metroPanel1.Controls.Add(this.txtPrimerNumero);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cmbSorteos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(39, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(488, 277);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(366, 75);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(83, 30);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseSelectable = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTerminarSorteo
            // 
            this.btnTerminarSorteo.Location = new System.Drawing.Point(132, 224);
            this.btnTerminarSorteo.Name = "btnTerminarSorteo";
            this.btnTerminarSorteo.Size = new System.Drawing.Size(165, 30);
            this.btnTerminarSorteo.TabIndex = 11;
            this.btnTerminarSorteo.Text = "Terminar Sorteo";
            this.btnTerminarSorteo.UseSelectable = true;
            this.btnTerminarSorteo.Click += new System.EventHandler(this.btnTerminarSorteo_Click);
            // 
            // txtTercerNumero
            // 
            // 
            // 
            // 
            this.txtTercerNumero.CustomButton.Image = null;
            this.txtTercerNumero.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.txtTercerNumero.CustomButton.Name = "";
            this.txtTercerNumero.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTercerNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTercerNumero.CustomButton.TabIndex = 1;
            this.txtTercerNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTercerNumero.CustomButton.UseSelectable = true;
            this.txtTercerNumero.CustomButton.Visible = false;
            this.txtTercerNumero.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTercerNumero.Lines = new string[0];
            this.txtTercerNumero.Location = new System.Drawing.Point(132, 176);
            this.txtTercerNumero.MaxLength = 2;
            this.txtTercerNumero.Name = "txtTercerNumero";
            this.txtTercerNumero.PasswordChar = '\0';
            this.txtTercerNumero.PromptText = "Tercer Número";
            this.txtTercerNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTercerNumero.SelectedText = "";
            this.txtTercerNumero.SelectionLength = 0;
            this.txtTercerNumero.SelectionStart = 0;
            this.txtTercerNumero.ShortcutsEnabled = true;
            this.txtTercerNumero.Size = new System.Drawing.Size(165, 30);
            this.txtTercerNumero.TabIndex = 9;
            this.txtTercerNumero.UseSelectable = true;
            this.txtTercerNumero.WaterMark = "Tercer Número";
            this.txtTercerNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTercerNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSegundoNumero
            // 
            // 
            // 
            // 
            this.txtSegundoNumero.CustomButton.Image = null;
            this.txtSegundoNumero.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.txtSegundoNumero.CustomButton.Name = "";
            this.txtSegundoNumero.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSegundoNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSegundoNumero.CustomButton.TabIndex = 1;
            this.txtSegundoNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSegundoNumero.CustomButton.UseSelectable = true;
            this.txtSegundoNumero.CustomButton.Visible = false;
            this.txtSegundoNumero.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSegundoNumero.Lines = new string[0];
            this.txtSegundoNumero.Location = new System.Drawing.Point(132, 126);
            this.txtSegundoNumero.MaxLength = 2;
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.PasswordChar = '\0';
            this.txtSegundoNumero.PromptText = "Segundo Número";
            this.txtSegundoNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSegundoNumero.SelectedText = "";
            this.txtSegundoNumero.SelectionLength = 0;
            this.txtSegundoNumero.SelectionStart = 0;
            this.txtSegundoNumero.ShortcutsEnabled = true;
            this.txtSegundoNumero.Size = new System.Drawing.Size(165, 30);
            this.txtSegundoNumero.TabIndex = 10;
            this.txtSegundoNumero.UseSelectable = true;
            this.txtSegundoNumero.WaterMark = "Segundo Número";
            this.txtSegundoNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSegundoNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPrimerNumero
            // 
            // 
            // 
            // 
            this.txtPrimerNumero.CustomButton.Image = null;
            this.txtPrimerNumero.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.txtPrimerNumero.CustomButton.Name = "";
            this.txtPrimerNumero.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrimerNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrimerNumero.CustomButton.TabIndex = 1;
            this.txtPrimerNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrimerNumero.CustomButton.UseSelectable = true;
            this.txtPrimerNumero.CustomButton.Visible = false;
            this.txtPrimerNumero.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrimerNumero.Lines = new string[0];
            this.txtPrimerNumero.Location = new System.Drawing.Point(132, 75);
            this.txtPrimerNumero.MaxLength = 2;
            this.txtPrimerNumero.Name = "txtPrimerNumero";
            this.txtPrimerNumero.PasswordChar = '\0';
            this.txtPrimerNumero.PromptText = "Primer Número";
            this.txtPrimerNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrimerNumero.SelectedText = "";
            this.txtPrimerNumero.SelectionLength = 0;
            this.txtPrimerNumero.SelectionStart = 0;
            this.txtPrimerNumero.ShortcutsEnabled = true;
            this.txtPrimerNumero.Size = new System.Drawing.Size(165, 30);
            this.txtPrimerNumero.TabIndex = 8;
            this.txtPrimerNumero.UseSelectable = true;
            this.txtPrimerNumero.WaterMark = "Primer Número";
            this.txtPrimerNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrimerNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(49, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Sorteos";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // cmbSorteos
            // 
            this.cmbSorteos.FormattingEnabled = true;
            this.cmbSorteos.ItemHeight = 23;
            this.cmbSorteos.Location = new System.Drawing.Point(132, 23);
            this.cmbSorteos.Name = "cmbSorteos";
            this.cmbSorteos.Size = new System.Drawing.Size(317, 29);
            this.cmbSorteos.TabIndex = 6;
            this.cmbSorteos.UseSelectable = true;
            // 
            // UGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "UGanadores";
            this.Size = new System.Drawing.Size(569, 348);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRandom;
        private MetroFramework.Controls.MetroButton btnTerminarSorteo;
        private MetroFramework.Controls.MetroTextBox txtTercerNumero;
        private MetroFramework.Controls.MetroTextBox txtSegundoNumero;
        private MetroFramework.Controls.MetroTextBox txtPrimerNumero;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbSorteos;
    }
}
