namespace AquiMix
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuariotxtbx = new System.Windows.Forms.TextBox();
            this.Contrasenatxtbx = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Psswd = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.ShowPsswdckbx = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuariotxtbx
            // 
            this.Usuariotxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariotxtbx.Location = new System.Drawing.Point(167, 38);
            this.Usuariotxtbx.Name = "Usuariotxtbx";
            this.Usuariotxtbx.Size = new System.Drawing.Size(180, 28);
            this.Usuariotxtbx.TabIndex = 0;
            this.Usuariotxtbx.TextChanged += new System.EventHandler(this.Usuariotxtbx_TextChanged);
            // 
            // Contrasenatxtbx
            // 
            this.Contrasenatxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenatxtbx.Location = new System.Drawing.Point(167, 79);
            this.Contrasenatxtbx.Name = "Contrasenatxtbx";
            this.Contrasenatxtbx.Size = new System.Drawing.Size(180, 28);
            this.Contrasenatxtbx.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(27, 38);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(90, 28);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Usuario";
            // 
            // Psswd
            // 
            this.Psswd.AutoSize = true;
            this.Psswd.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psswd.Location = new System.Drawing.Point(27, 77);
            this.Psswd.Name = "Psswd";
            this.Psswd.Size = new System.Drawing.Size(127, 28);
            this.Psswd.TabIndex = 3;
            this.Psswd.Text = "Contraseña";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(370, 40);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(103, 28);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // ShowPsswdckbx
            // 
            this.ShowPsswdckbx.AutoSize = true;
            this.ShowPsswdckbx.Location = new System.Drawing.Point(370, 90);
            this.ShowPsswdckbx.Name = "ShowPsswdckbx";
            this.ShowPsswdckbx.Size = new System.Drawing.Size(61, 17);
            this.ShowPsswdckbx.TabIndex = 5;
            this.ShowPsswdckbx.Text = "Mostrar";
            this.ShowPsswdckbx.UseVisualStyleBackColor = true;
            this.ShowPsswdckbx.CheckedChanged += new System.EventHandler(this.ShowPsswdckbx_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPsswdckbx);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Psswd);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Contrasenatxtbx);
            this.Controls.Add(this.Usuariotxtbx);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquiMix";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuariotxtbx;
        private System.Windows.Forms.TextBox Contrasenatxtbx;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Psswd;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.CheckBox ShowPsswdckbx;
        private System.Windows.Forms.Button button1;
    }
}

