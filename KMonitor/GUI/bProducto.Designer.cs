namespace KMonitor.GUI
{
    partial class bProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.rbtnFamilia = new System.Windows.Forms.RadioButton();
            this.rbtnProducto = new System.Windows.Forms.RadioButton();
            this.txtnombreQuery = new System.Windows.Forms.TextBox();
            this.cboFamilia_Query = new System.Windows.Forms.ComboBox();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockminimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventariable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.gpBox);
            this.panel1.Controls.Add(this.txtnombreQuery);
            this.panel1.Controls.Add(this.cboFamilia_Query);
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 53);
            this.panel1.TabIndex = 81;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 23);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Seleccionar y salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpBox
            // 
            this.gpBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gpBox.Controls.Add(this.rbtnFamilia);
            this.gpBox.Controls.Add(this.rbtnProducto);
            this.gpBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpBox.Location = new System.Drawing.Point(9, 3);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(281, 47);
            this.gpBox.TabIndex = 63;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "Filtrar datos por:";
            // 
            // rbtnFamilia
            // 
            this.rbtnFamilia.AutoSize = true;
            this.rbtnFamilia.Location = new System.Drawing.Point(197, 17);
            this.rbtnFamilia.Name = "rbtnFamilia";
            this.rbtnFamilia.Size = new System.Drawing.Size(57, 17);
            this.rbtnFamilia.TabIndex = 53;
            this.rbtnFamilia.TabStop = true;
            this.rbtnFamilia.Text = "Familia";
            this.rbtnFamilia.UseVisualStyleBackColor = true;
            this.rbtnFamilia.CheckedChanged += new System.EventHandler(this.rbtnFamilia_CheckedChanged);
            // 
            // rbtnProducto
            // 
            this.rbtnProducto.AutoSize = true;
            this.rbtnProducto.Location = new System.Drawing.Point(105, 17);
            this.rbtnProducto.Name = "rbtnProducto";
            this.rbtnProducto.Size = new System.Drawing.Size(68, 17);
            this.rbtnProducto.TabIndex = 52;
            this.rbtnProducto.TabStop = true;
            this.rbtnProducto.Text = "Producto";
            this.rbtnProducto.UseVisualStyleBackColor = true;
            this.rbtnProducto.CheckedChanged += new System.EventHandler(this.rbtnProducto_CheckedChanged);
            // 
            // txtnombreQuery
            // 
            this.txtnombreQuery.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombreQuery.Location = new System.Drawing.Point(290, 20);
            this.txtnombreQuery.Name = "txtnombreQuery";
            this.txtnombreQuery.Size = new System.Drawing.Size(343, 20);
            this.txtnombreQuery.TabIndex = 58;
            this.txtnombreQuery.TextChanged += new System.EventHandler(this.txtnombreQuery_TextChanged);
            // 
            // cboFamilia_Query
            // 
            this.cboFamilia_Query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilia_Query.FormattingEnabled = true;
            this.cboFamilia_Query.Location = new System.Drawing.Point(290, 20);
            this.cboFamilia_Query.Name = "cboFamilia_Query";
            this.cboFamilia_Query.Size = new System.Drawing.Size(276, 21);
            this.cboFamilia_Query.TabIndex = 59;
            this.cboFamilia_Query.Visible = false;
            this.cboFamilia_Query.SelectedIndexChanged += new System.EventHandler(this.cboFamilia_Query_SelectedIndexChanged);
            // 
            // dgProducto
            // 
            this.dgProducto.AllowUserToAddRows = false;
            this.dgProducto.AllowUserToDeleteRows = false;
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.familia,
            this.nombre,
            this.descripcion,
            this.costo,
            this.precio,
            this.unidadMedida,
            this.stock,
            this.stockminimo,
            this.inventariable,
            this.foto});
            this.dgProducto.Location = new System.Drawing.Point(11, 68);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.ReadOnly = true;
            this.dgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducto.Size = new System.Drawing.Size(769, 260);
            this.dgProducto.TabIndex = 82;
            this.dgProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducto_CellDoubleClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 30;
            // 
            // familia
            // 
            this.familia.DataPropertyName = "familia";
            this.familia.HeaderText = "Familia";
            this.familia.Name = "familia";
            this.familia.ReadOnly = true;
            this.familia.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            this.descripcion.Width = 200;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "costo";
            this.costo.HeaderText = "costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 50;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 50;
            // 
            // unidadMedida
            // 
            this.unidadMedida.DataPropertyName = "unidadMedida";
            this.unidadMedida.HeaderText = "Unidad";
            this.unidadMedida.Name = "unidadMedida";
            this.unidadMedida.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // stockminimo
            // 
            this.stockminimo.DataPropertyName = "stockminimo";
            this.stockminimo.HeaderText = "Stock Mínimo";
            this.stockminimo.Name = "stockminimo";
            this.stockminimo.ReadOnly = true;
            this.stockminimo.Width = 50;
            // 
            // inventariable
            // 
            this.inventariable.DataPropertyName = "inventariable";
            this.inventariable.HeaderText = "Inventariable";
            this.inventariable.Name = "inventariable";
            this.inventariable.ReadOnly = true;
            this.inventariable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inventariable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inventariable.Width = 75;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // bProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 353);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar producto";
            this.Load += new System.EventHandler(this.bProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.RadioButton rbtnFamilia;
        private System.Windows.Forms.RadioButton rbtnProducto;
        private System.Windows.Forms.TextBox txtnombreQuery;
        private System.Windows.Forms.ComboBox cboFamilia_Query;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockminimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inventariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
    }
}