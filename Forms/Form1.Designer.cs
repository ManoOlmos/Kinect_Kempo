namespace IPN1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.Registrate = new System.Windows.Forms.LinkLabel();
            this.OlvidasteContrasenia = new System.Windows.Forms.LinkLabel();
            this.MostrarContrasenia = new System.Windows.Forms.CheckBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 1049);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(19, 18);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(-56, -2);
            this.axWindowsMediaPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(1595, 880);
            this.axWindowsMediaPlayer2.TabIndex = 10;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Contrasenia);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.IniciarSesion);
            this.panel1.Controls.Add(this.Registrate);
            this.panel1.Controls.Add(this.OlvidasteContrasenia);
            this.panel1.Controls.Add(this.MostrarContrasenia);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Location = new System.Drawing.Point(219, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 657);
            this.panel1.TabIndex = 11;
            // 
            // Contrasenia
            // 
            this.Contrasenia.BackColor = System.Drawing.Color.AliceBlue;
            this.Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contrasenia.Font = new System.Drawing.Font("Karate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenia.ForeColor = System.Drawing.Color.LightGray;
            this.Contrasenia.Location = new System.Drawing.Point(121, 177);
            this.Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(305, 46);
            this.Contrasenia.TabIndex = 7;
            this.Contrasenia.Text = "Password";
            this.Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contrasenia.Enter += new System.EventHandler(this.Contrasenia_Enter);
            this.Contrasenia.Leave += new System.EventHandler(this.Contrasenia_Leave);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.BackgroundImage = global::IPN1.Properties.Resources.BS1;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.Black;
            this.Salir.Location = new System.Drawing.Point(223, 548);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(91, 28);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            this.Salir.MouseLeave += new System.EventHandler(this.Salir_Leave);
            this.Salir.MouseHover += new System.EventHandler(this.Salir_Hover);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.IniciarSesion.BackgroundImage = global::IPN1.Properties.Resources.BI1;
            this.IniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IniciarSesion.FlatAppearance.BorderSize = 0;
            this.IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion.Font = new System.Drawing.Font("Script MT Bold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.IniciarSesion.Location = new System.Drawing.Point(152, 460);
            this.IniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(232, 62);
            this.IniciarSesion.TabIndex = 5;
            this.IniciarSesion.Text = "Iniciar";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            this.IniciarSesion.MouseLeave += new System.EventHandler(this.Inicio_Leave);
            this.IniciarSesion.MouseHover += new System.EventHandler(this.Inicio_Hover);
            // 
            // Registrate
            // 
            this.Registrate.AutoSize = true;
            this.Registrate.BackColor = System.Drawing.Color.Transparent;
            this.Registrate.LinkColor = System.Drawing.Color.AliceBlue;
            this.Registrate.Location = new System.Drawing.Point(155, 377);
            this.Registrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registrate.Name = "Registrate";
            this.Registrate.Size = new System.Drawing.Size(223, 17);
            this.Registrate.TabIndex = 4;
            this.Registrate.TabStop = true;
            this.Registrate.Text = "¿No tienes cuenta? REGISTRATE";
            this.Registrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registrate_LinkClicked);
            // 
            // OlvidasteContrasenia
            // 
            this.OlvidasteContrasenia.AutoSize = true;
            this.OlvidasteContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.OlvidasteContrasenia.LinkColor = System.Drawing.Color.AliceBlue;
            this.OlvidasteContrasenia.Location = new System.Drawing.Point(180, 337);
            this.OlvidasteContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OlvidasteContrasenia.Name = "OlvidasteContrasenia";
            this.OlvidasteContrasenia.Size = new System.Drawing.Size(176, 17);
            this.OlvidasteContrasenia.TabIndex = 3;
            this.OlvidasteContrasenia.TabStop = true;
            this.OlvidasteContrasenia.Text = "¿Olvidaste tu Contraseña?";
            this.OlvidasteContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OlvidasteContrasenia_LinkClicked);
            // 
            // MostrarContrasenia
            // 
            this.MostrarContrasenia.AutoSize = true;
            this.MostrarContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.MostrarContrasenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostrarContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarContrasenia.ForeColor = System.Drawing.Color.AliceBlue;
            this.MostrarContrasenia.Location = new System.Drawing.Point(188, 276);
            this.MostrarContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarContrasenia.Name = "MostrarContrasenia";
            this.MostrarContrasenia.Size = new System.Drawing.Size(151, 21);
            this.MostrarContrasenia.TabIndex = 2;
            this.MostrarContrasenia.Text = "Mostrar Contraseña";
            this.MostrarContrasenia.UseVisualStyleBackColor = false;
            this.MostrarContrasenia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.AliceBlue;
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Usuario.Font = new System.Drawing.Font("Karate", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.LightGray;
            this.Usuario.Location = new System.Drawing.Point(47, 70);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(457, 66);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.UseWaitCursor = true;
            this.Usuario.Enter += new System.EventHandler(this.NombreUsuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.NombreUsuario_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.CheckBox MostrarContrasenia;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.LinkLabel Registrate;
        private System.Windows.Forms.LinkLabel OlvidasteContrasenia;
        private System.Windows.Forms.TextBox Contrasenia;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}

