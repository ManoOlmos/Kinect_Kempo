namespace IPN1
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Progreso = new System.Windows.Forms.Button();
            this.Cuenta = new System.Windows.Forms.Button();
            this.IniciarEntrenamiento = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-4, -5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1383, 791);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IPN1.Properties.Resources.FondoMenu;
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.IniciarEntrenamiento);
            this.panel1.Controls.Add(this.Cuenta);
            this.panel1.Controls.Add(this.Progreso);
            this.panel1.Location = new System.Drawing.Point(110, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 696);
            this.panel1.TabIndex = 5;
            // 
            // Progreso
            // 
            this.Progreso.BackColor = System.Drawing.Color.Transparent;
            this.Progreso.Cursor = System.Windows.Forms.Cursors.Default;
            this.Progreso.FlatAppearance.BorderSize = 0;
            this.Progreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Progreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Progreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Progreso.Image = global::IPN1.Properties.Resources.Miprogreso;
            this.Progreso.Location = new System.Drawing.Point(29, 211);
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(359, 124);
            this.Progreso.TabIndex = 1;
            this.Progreso.UseVisualStyleBackColor = false;
            this.Progreso.Click += new System.EventHandler(this.Progreso_Click);
            this.Progreso.MouseLeave += new System.EventHandler(this.Miprogreso_Leave);
            this.Progreso.MouseHover += new System.EventHandler(this.Miprogreso_Hover);
            // 
            // Cuenta
            // 
            this.Cuenta.BackColor = System.Drawing.Color.Transparent;
            this.Cuenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cuenta.FlatAppearance.BorderSize = 0;
            this.Cuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuenta.Image = global::IPN1.Properties.Resources.Micuenta;
            this.Cuenta.Location = new System.Drawing.Point(29, 376);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(359, 125);
            this.Cuenta.TabIndex = 2;
            this.Cuenta.UseVisualStyleBackColor = false;
            this.Cuenta.Click += new System.EventHandler(this.Cuenta_Click);
            this.Cuenta.MouseLeave += new System.EventHandler(this.Micuenta_Leave);
            this.Cuenta.MouseHover += new System.EventHandler(this.Micuenta_Hover);
            // 
            // IniciarEntrenamiento
            // 
            this.IniciarEntrenamiento.BackColor = System.Drawing.Color.Transparent;
            this.IniciarEntrenamiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.IniciarEntrenamiento.FlatAppearance.BorderSize = 0;
            this.IniciarEntrenamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IniciarEntrenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IniciarEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarEntrenamiento.Image = global::IPN1.Properties.Resources.B1;
            this.IniciarEntrenamiento.Location = new System.Drawing.Point(29, 70);
            this.IniciarEntrenamiento.Name = "IniciarEntrenamiento";
            this.IniciarEntrenamiento.Size = new System.Drawing.Size(359, 125);
            this.IniciarEntrenamiento.TabIndex = 0;
            this.IniciarEntrenamiento.UseMnemonic = false;
            this.IniciarEntrenamiento.UseVisualStyleBackColor = false;
            this.IniciarEntrenamiento.Click += new System.EventHandler(this.IniciarEntrenamiento_Click);
            this.IniciarEntrenamiento.MouseLeave += new System.EventHandler(this.MouseLeave_Iniciar);
            this.IniciarEntrenamiento.MouseHover += new System.EventHandler(this.MouseHover_Iniciar);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Image = global::IPN1.Properties.Resources.Salir;
            this.Salir.Location = new System.Drawing.Point(29, 534);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(359, 113);
            this.Salir.TabIndex = 3;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_Leave);
            this.Salir.MouseHover += new System.EventHandler(this.Salir_Hover);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 772);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuInicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button IniciarEntrenamiento;
        private System.Windows.Forms.Button Cuenta;
        private System.Windows.Forms.Button Progreso;
    }
}