namespace AquiMix
{
    partial class inventario
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
            this.button1 = new System.Windows.Forms.Button();
            this.Bienvenidabtn = new System.Windows.Forms.Button();
            this.Menudgv = new System.Windows.Forms.DataGridView();
            this.aquiMixDataSet = new AquiMix.AquiMixDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new AquiMix.AquiMixDataSetTableAdapters.InventarioTableAdapter();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new AquiMix.AquiMixDataSetTableAdapters.MenuTableAdapter();
            this.idPlatilloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPlatilloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Menudgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquiMixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bienvenidabtn
            // 
            this.Bienvenidabtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidabtn.Location = new System.Drawing.Point(368, 383);
            this.Bienvenidabtn.Name = "Bienvenidabtn";
            this.Bienvenidabtn.Size = new System.Drawing.Size(98, 31);
            this.Bienvenidabtn.TabIndex = 1;
            this.Bienvenidabtn.Text = "Regresar";
            this.Bienvenidabtn.UseVisualStyleBackColor = true;
            this.Bienvenidabtn.Click += new System.EventHandler(this.Bienvenidabtn_Click);
            // 
            // Menudgv
            // 
            this.Menudgv.AutoGenerateColumns = false;
            this.Menudgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menudgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlatilloDataGridViewTextBoxColumn,
            this.nomPlatilloDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.Menudgv.DataSource = this.menuBindingSource;
            this.Menudgv.Location = new System.Drawing.Point(12, 28);
            this.Menudgv.Name = "Menudgv";
            this.Menudgv.Size = new System.Drawing.Size(454, 349);
            this.Menudgv.TabIndex = 2;
            // 
            // aquiMixDataSet
            // 
            this.aquiMixDataSet.DataSetName = "AquiMixDataSet";
            this.aquiMixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.aquiMixDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.aquiMixDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // idPlatilloDataGridViewTextBoxColumn
            // 
            this.idPlatilloDataGridViewTextBoxColumn.DataPropertyName = "idPlatillo";
            this.idPlatilloDataGridViewTextBoxColumn.HeaderText = "idPlatillo";
            this.idPlatilloDataGridViewTextBoxColumn.Name = "idPlatilloDataGridViewTextBoxColumn";
            // 
            // nomPlatilloDataGridViewTextBoxColumn
            // 
            this.nomPlatilloDataGridViewTextBoxColumn.DataPropertyName = "nomPlatillo";
            this.nomPlatilloDataGridViewTextBoxColumn.HeaderText = "nomPlatillo";
            this.nomPlatilloDataGridViewTextBoxColumn.Name = "nomPlatilloDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 425);
            this.Controls.Add(this.Menudgv);
            this.Controls.Add(this.Bienvenidabtn);
            this.Controls.Add(this.button1);
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menudgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquiMixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bienvenidabtn;
        private System.Windows.Forms.DataGridView Menudgv;
        private AquiMixDataSet aquiMixDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private AquiMixDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private AquiMixDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatilloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPlatilloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}