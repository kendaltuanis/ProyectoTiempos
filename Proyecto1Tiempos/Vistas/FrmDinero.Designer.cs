namespace Proyecto1Tiempos.Vistas
{
    partial class FrmDinero
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
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.txtDinero = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(137, 106);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDinero
            // 
            // 
            // 
            // 
            this.txtDinero.CustomButton.Image = null;
            this.txtDinero.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtDinero.CustomButton.Name = "";
            this.txtDinero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDinero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDinero.CustomButton.TabIndex = 1;
            this.txtDinero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDinero.CustomButton.UseSelectable = true;
            this.txtDinero.CustomButton.Visible = false;
            this.txtDinero.Lines = new string[0];
            this.txtDinero.Location = new System.Drawing.Point(32, 76);
            this.txtDinero.MaxLength = 32767;
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.PasswordChar = '\0';
            this.txtDinero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDinero.SelectedText = "";
            this.txtDinero.SelectionLength = 0;
            this.txtDinero.SelectionStart = 0;
            this.txtDinero.ShortcutsEnabled = true;
            this.txtDinero.Size = new System.Drawing.Size(180, 23);
            this.txtDinero.TabIndex = 0;
            this.txtDinero.UseSelectable = true;
            this.txtDinero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDinero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDinero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinero_KeyPress);
            this.txtDinero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDinero_KeyUp);
            // 
            // FrmDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 162);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDinero);
            this.Name = "FrmDinero";
            this.Text = "Dinero disponible";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroTextBox txtDinero;
    }
}