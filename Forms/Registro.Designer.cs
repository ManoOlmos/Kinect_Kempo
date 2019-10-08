namespace IPN1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Guardar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.ConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido1 = new System.Windows.Forms.TextBox();
            this.Apellido2 = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Estatura = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(1504, 806);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(121, 52);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(1648, 806);
            this.Atras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(124, 52);
            this.Atras.TabIndex = 1;
            this.Atras.Text = "Atrás";
            this.Atras.UseVisualStyleBackColor = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.NombreUsuario.Location = new System.Drawing.Point(40, 182);
            this.NombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(632, 46);
            this.NombreUsuario.TabIndex = 2;
            this.NombreUsuario.Text = "Nombre de Usuario";
            this.NombreUsuario.Enter += new System.EventHandler(this.NombreUsuario_Enter);
            this.NombreUsuario.Leave += new System.EventHandler(this.NombreUsuario_Leave);
            // 
            // Contrasenia
            // 
            this.Contrasenia.BackColor = System.Drawing.SystemColors.Menu;
            this.Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenia.ForeColor = System.Drawing.Color.LightGray;
            this.Contrasenia.Location = new System.Drawing.Point(755, 182);
            this.Contrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contrasenia.Multiline = true;
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(415, 50);
            this.Contrasenia.TabIndex = 3;
            this.Contrasenia.Text = "Contraseña";
            this.Contrasenia.Enter += new System.EventHandler(this.Contrasenia_Enter);
            this.Contrasenia.Leave += new System.EventHandler(this.Contrasenia_Leave);
            // 
            // ConfirmarContrasenia
            // 
            this.ConfirmarContrasenia.BackColor = System.Drawing.SystemColors.Menu;
            this.ConfirmarContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContrasenia.ForeColor = System.Drawing.Color.LightGray;
            this.ConfirmarContrasenia.Location = new System.Drawing.Point(1240, 182);
            this.ConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmarContrasenia.Multiline = true;
            this.ConfirmarContrasenia.Name = "ConfirmarContrasenia";
            this.ConfirmarContrasenia.Size = new System.Drawing.Size(415, 50);
            this.ConfirmarContrasenia.TabIndex = 4;
            this.ConfirmarContrasenia.Text = "Confirmar Contraseña";
            this.ConfirmarContrasenia.Enter += new System.EventHandler(this.ConfirmarContrasenia_Enter);
            this.ConfirmarContrasenia.Leave += new System.EventHandler(this.ConfirmarContrasenia_Leave);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Menu;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.LightGray;
            this.Nombre.Location = new System.Drawing.Point(40, 266);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre.Multiline = true;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(632, 51);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Nombre";
            this.Nombre.Enter += new System.EventHandler(this.Nombre_Enter);
            this.Nombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // Apellido1
            // 
            this.Apellido1.BackColor = System.Drawing.SystemColors.Menu;
            this.Apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido1.ForeColor = System.Drawing.Color.LightGray;
            this.Apellido1.Location = new System.Drawing.Point(755, 266);
            this.Apellido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apellido1.Multiline = true;
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Size = new System.Drawing.Size(415, 51);
            this.Apellido1.TabIndex = 6;
            this.Apellido1.Text = "Apellido Paterno";
            this.Apellido1.Enter += new System.EventHandler(this.Apellido1_Enter);
            this.Apellido1.Leave += new System.EventHandler(this.Apellido1_Leave);
            // 
            // Apellido2
            // 
            this.Apellido2.BackColor = System.Drawing.SystemColors.Menu;
            this.Apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido2.ForeColor = System.Drawing.Color.LightGray;
            this.Apellido2.Location = new System.Drawing.Point(1240, 266);
            this.Apellido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apellido2.Multiline = true;
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.Size = new System.Drawing.Size(415, 51);
            this.Apellido2.TabIndex = 7;
            this.Apellido2.Text = "Apellido Materno";
            this.Apellido2.Enter += new System.EventHandler(this.Apellido2_Enter);
            this.Apellido2.Leave += new System.EventHandler(this.Apellido2_Leave);
            // 
            // Edad
            // 
            this.Edad.BackColor = System.Drawing.SystemColors.Menu;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.ForeColor = System.Drawing.Color.LightGray;
            this.Edad.Location = new System.Drawing.Point(40, 357);
            this.Edad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edad.Multiline = true;
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(133, 51);
            this.Edad.TabIndex = 8;
            this.Edad.Text = "Edad";
            this.Edad.Enter += new System.EventHandler(this.Edad_Enter);
            this.Edad.Leave += new System.EventHandler(this.Edad_Leave);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.Menu;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.Color.LightGray;
            this.Correo.Location = new System.Drawing.Point(183, 357);
            this.Correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Correo.Multiline = true;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(491, 51);
            this.Correo.TabIndex = 9;
            this.Correo.Text = "Correo Electrónico";
            this.Correo.Enter += new System.EventHandler(this.Correo_Enter);
            this.Correo.Leave += new System.EventHandler(this.Correo_Leave);
            // 
            // Peso
            // 
            this.Peso.BackColor = System.Drawing.SystemColors.Menu;
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.ForeColor = System.Drawing.Color.LightGray;
            this.Peso.Location = new System.Drawing.Point(37, 441);
            this.Peso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Peso.Multiline = true;
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(324, 52);
            this.Peso.TabIndex = 10;
            this.Peso.Text = "Peso (Opcional)";
            this.Peso.Enter += new System.EventHandler(this.Peso_Enter);
            this.Peso.Leave += new System.EventHandler(this.Peso_Leave);
            // 
            // Estatura
            // 
            this.Estatura.BackColor = System.Drawing.SystemColors.Menu;
            this.Estatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estatura.ForeColor = System.Drawing.Color.LightGray;
            this.Estatura.Location = new System.Drawing.Point(37, 526);
            this.Estatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Estatura.Multiline = true;
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(324, 52);
            this.Estatura.TabIndex = 11;
            this.Estatura.Text = "Estatura (Opcional) ";
            this.Estatura.Enter += new System.EventHandler(this.Estatura_Enter);
            this.Estatura.Leave += new System.EventHandler(this.Estatura_Leave);
            // 
            // Sexo
            // 
            this.Sexo.BackColor = System.Drawing.SystemColors.Menu;
            this.Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.ForeColor = System.Drawing.Color.Black;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Mujer",
            "Hombre"});
            this.Sexo.Location = new System.Drawing.Point(37, 613);
            this.Sexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(185, 47);
            this.Sexo.TabIndex = 12;
            this.Sexo.Text = "Género";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-9, -12);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1595, 880);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1281, 368);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 329);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Karate", 60F);
            this.label1.Location = new System.Drawing.Point(645, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 115);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRO";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 950);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido2);
            this.Controls.Add(this.Apellido1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ConfirmarContrasenia);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.TextBox Contrasenia;
        private System.Windows.Forms.TextBox ConfirmarContrasenia;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido1;
        private System.Windows.Forms.TextBox Apellido2;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Estatura;
        private System.Windows.Forms.ComboBox Sexo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}