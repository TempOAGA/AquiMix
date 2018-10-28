namespace AquiMix
{
    partial class BienvenidaUsuario
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelAdministrador = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelGerente = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panelCajero = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panelAdministrador.SuspendLayout();
            this.panelGerente.SuspendLayout();
            this.panelCajero.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(18, 47);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(90, 28);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // panelAdministrador
            // 
            this.panelAdministrador.Controls.Add(this.label2);
            this.panelAdministrador.Controls.Add(this.dateTimePicker1);
            this.panelAdministrador.Location = new System.Drawing.Point(12, 117);
            this.panelAdministrador.Name = "panelAdministrador";
            this.panelAdministrador.Size = new System.Drawing.Size(776, 321);
            this.panelAdministrador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrador";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panelGerente
            // 
            this.panelGerente.Controls.Add(this.label5);
            this.panelGerente.Controls.Add(this.dateTimePicker2);
            this.panelGerente.Location = new System.Drawing.Point(12, 117);
            this.panelGerente.Name = "panelGerente";
            this.panelGerente.Size = new System.Drawing.Size(776, 321);
            this.panelGerente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gerente";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(102, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // panelCajero
            // 
            this.panelCajero.Controls.Add(this.label3);
            this.panelCajero.Controls.Add(this.dateTimePicker3);
            this.panelCajero.Location = new System.Drawing.Point(12, 117);
            this.panelCajero.Name = "panelCajero";
            this.panelCajero.Size = new System.Drawing.Size(776, 321);
            this.panelCajero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cajero";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(86, 3);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // BienvenidaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAdministrador);
            this.Controls.Add(this.panelCajero);
            this.Controls.Add(this.panelGerente);
            this.Controls.Add(this.labelUsuario);
            this.Name = "BienvenidaUsuario";
            this.Text = "BienvenidaUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BienvenidaUsuario_FormClosed);
            this.panelAdministrador.ResumeLayout(false);
            this.panelAdministrador.PerformLayout();
            this.panelGerente.ResumeLayout(false);
            this.panelGerente.PerformLayout();
            this.panelCajero.ResumeLayout(false);
            this.panelCajero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.FlowLayoutPanel panelAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel panelGerente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.FlowLayoutPanel panelCajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}