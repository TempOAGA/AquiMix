namespace AquiMix
{
    partial class Cobro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dinerotbx = new System.Windows.Forms.TextBox();
            this.Totaltbx = new System.Windows.Forms.TextBox();
            this.Cambiotbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAMBIO";
            // 
            // Dinerotbx
            // 
            this.Dinerotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinerotbx.Location = new System.Drawing.Point(62, 26);
            this.Dinerotbx.Name = "Dinerotbx";
            this.Dinerotbx.Size = new System.Drawing.Size(124, 31);
            this.Dinerotbx.TabIndex = 5;
            this.Dinerotbx.TextChanged += new System.EventHandler(this.Dinerotbx_TextChanged);
            this.Dinerotbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Totaltbx
            // 
            this.Totaltbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaltbx.Location = new System.Drawing.Point(124, 72);
            this.Totaltbx.Name = "Totaltbx";
            this.Totaltbx.ReadOnly = true;
            this.Totaltbx.Size = new System.Drawing.Size(124, 31);
            this.Totaltbx.TabIndex = 6;
            // 
            // Cambiotbx
            // 
            this.Cambiotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambiotbx.Location = new System.Drawing.Point(124, 109);
            this.Cambiotbx.Name = "Cambiotbx";
            this.Cambiotbx.ReadOnly = true;
            this.Cambiotbx.Size = new System.Drawing.Size(124, 31);
            this.Cambiotbx.TabIndex = 7;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 159);
            this.Controls.Add(this.Cambiotbx);
            this.Controls.Add(this.Totaltbx);
            this.Controls.Add(this.Dinerotbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dinerotbx;
        private System.Windows.Forms.TextBox Totaltbx;
        private System.Windows.Forms.TextBox Cambiotbx;
    }
}