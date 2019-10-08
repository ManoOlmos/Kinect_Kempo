namespace IPN1
{
    partial class TerminosDeUso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminosDeUso));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            resources.GetString("listBox2.Items"),
            resources.GetString("listBox2.Items1"),
            resources.GetString("listBox2.Items2"),
            resources.GetString("listBox2.Items3"),
            resources.GetString("listBox2.Items4"),
            resources.GetString("listBox2.Items5"),
            resources.GetString("listBox2.Items6"),
            resources.GetString("listBox2.Items7"),
            resources.GetString("listBox2.Items8"),
            resources.GetString("listBox2.Items9"),
            resources.GetString("listBox2.Items10"),
            resources.GetString("listBox2.Items11")});
            this.listBox2.Name = "listBox2";
            this.listBox2.TabStop = false;
            this.listBox2.UseTabStops = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OK.Image = global::IPN1.Properties.Resources.BO1;
            this.OK.Name = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.OK.MouseLeave += new System.EventHandler(this.OK_Leave);
            this.OK.MouseHover += new System.EventHandler(this.OK_Hover);
            // 
            // TerminosDeUso
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.OK);
            this.Controls.Add(this.listBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminosDeUso";
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ListBox listBox1;
        //private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button OK;
    }
}