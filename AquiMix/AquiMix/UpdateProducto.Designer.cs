namespace AquiMix
{
    partial class UpdateProducto
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
            this.components = new System.ComponentModel.Container();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquiMixDataSet = new AquiMix.AquiMixDataSet();
            this.menuTableAdapter = new AquiMix.AquiMixDataSetTableAdapters.MenuTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPlatillo = new System.Windows.Forms.TextBox();
            this.rtbxDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquiMixDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.aquiMixDataSet;
            // 
            // aquiMixDataSet
            // 
            this.aquiMixDataSet.DataSetName = "AquiMixDataSet";
            this.aquiMixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(153, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxMenu
            // 
            this.cbxMenu.DataSource = this.menuBindingSource;
            this.cbxMenu.DisplayMember = "nomPlatillo";
            this.cbxMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(134, 31);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(229, 29);
            this.cbxMenu.TabIndex = 2;
            this.cbxMenu.ValueMember = "idPlatillo";
            this.cbxMenu.SelectionChangeCommitted += new System.EventHandler(this.cbxMenu_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Platillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // tbxPlatillo
            // 
            this.tbxPlatillo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlatillo.Location = new System.Drawing.Point(134, 93);
            this.tbxPlatillo.Name = "tbxPlatillo";
            this.tbxPlatillo.Size = new System.Drawing.Size(229, 28);
            this.tbxPlatillo.TabIndex = 6;
            // 
            // rtbxDescripcion
            // 
            this.rtbxDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxDescripcion.Location = new System.Drawing.Point(134, 220);
            this.rtbxDescripcion.Name = "rtbxDescripcion";
            this.rtbxDescripcion.Size = new System.Drawing.Size(229, 160);
            this.rtbxDescripcion.TabIndex = 8;
            this.rtbxDescripcion.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(261, 403);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 32);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio.Location = new System.Drawing.Point(134, 154);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(229, 28);
            this.tbxPrecio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modificar";
            // 
            // UpdateProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 447);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rtbxDescripcion);
            this.Controls.Add(this.tbxPlatillo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMenu);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateProducto";
            this.Text = "UpdateProducto";
            this.Load += new System.EventHandler(this.UpdateProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquiMixDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AquiMixDataSet aquiMixDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private AquiMixDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPlatillo;
        private System.Windows.Forms.RichTextBox rtbxDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MaskedTextBox tbxPrecio;
        private System.Windows.Forms.Label label4;
    }
}