namespace KMonitor.GUI
{
    partial class Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgKardex = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.chkFiltro = new System.Windows.Forms.CheckBox();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picturekOk2 = new System.Windows.Forms.PictureBox();
            this.picturekOk1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btnQuitarFiltroFechas = new System.Windows.Forms.Button();
            this.txtFecha2 = new System.Windows.Forms.TextBox();
            this.txtFecha1 = new System.Windows.Forms.TextBox();
            this.lblCreaVista = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturekOk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturekOk1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKardex
            // 
            this.dgKardex.AllowUserToAddRows = false;
            this.dgKardex.AllowUserToDeleteRows = false;
            this.dgKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.documento,
            this.descripcion,
            this.tipo,
            this.entradas,
            this.salidas,
            this.costo,
            this.saldo,
            this.stock});
            this.dgKardex.Location = new System.Drawing.Point(25, 70);
            this.dgKardex.Name = "dgKardex";
            this.dgKardex.ReadOnly = true;
            this.dgKardex.Size = new System.Drawing.Size(754, 282);
            this.dgKardex.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(590, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(189, 26);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar producto";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto (opcional)";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(127, 26);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(444, 26);
            this.txtProducto.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::KMonitor.Properties.Resources.close;
            this.btnSalir.Location = new System.Drawing.Point(658, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 75);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(427, 392);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(225, 44);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(127, 26);
            this.txtIdProducto.Multiline = true;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(55, 26);
            this.txtIdProducto.TabIndex = 7;
            this.txtIdProducto.Visible = false;
            // 
            // chkFiltro
            // 
            this.chkFiltro.AutoSize = true;
            this.chkFiltro.Location = new System.Drawing.Point(590, 3);
            this.chkFiltro.Name = "chkFiltro";
            this.chkFiltro.Size = new System.Drawing.Size(81, 17);
            this.chkFiltro.TabIndex = 8;
            this.chkFiltro.Text = "Activar filtro";
            this.chkFiltro.UseVisualStyleBackColor = true;
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Kardex General",
            "Kardex/Fecha",
            "Kardex/Fecha-Producto",
            "Kardex/Producto",
            "Kardex/Producto-Fecha"});
            this.cboTipoReporte.Location = new System.Drawing.Point(509, 361);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(143, 21);
            this.cboTipoReporte.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de reporte";
            // 
            // picturekOk2
            // 
            this.picturekOk2.Image = ((System.Drawing.Image)(resources.GetObject("picturekOk2.Image")));
            this.picturekOk2.Location = new System.Drawing.Point(317, 371);
            this.picturekOk2.Name = "picturekOk2";
            this.picturekOk2.Size = new System.Drawing.Size(32, 32);
            this.picturekOk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturekOk2.TabIndex = 20;
            this.picturekOk2.TabStop = false;
            this.picturekOk2.Visible = false;
            // 
            // picturekOk1
            // 
            this.picturekOk1.Image = ((System.Drawing.Image)(resources.GetObject("picturekOk1.Image")));
            this.picturekOk1.Location = new System.Drawing.Point(152, 371);
            this.picturekOk1.Name = "picturekOk1";
            this.picturekOk1.Size = new System.Drawing.Size(32, 32);
            this.picturekOk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturekOk1.TabIndex = 19;
            this.picturekOk1.TabStop = false;
            this.picturekOk1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Desde";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(190, 377);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(124, 20);
            this.dateEnd.TabIndex = 16;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(25, 377);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(124, 20);
            this.dateStart.TabIndex = 15;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // btnQuitarFiltroFechas
            // 
            this.btnQuitarFiltroFechas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitarFiltroFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarFiltroFechas.Image")));
            this.btnQuitarFiltroFechas.Location = new System.Drawing.Point(355, 371);
            this.btnQuitarFiltroFechas.Name = "btnQuitarFiltroFechas";
            this.btnQuitarFiltroFechas.Size = new System.Drawing.Size(42, 32);
            this.btnQuitarFiltroFechas.TabIndex = 130;
            this.btnQuitarFiltroFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitarFiltroFechas.UseVisualStyleBackColor = false;
            this.btnQuitarFiltroFechas.Visible = false;
            this.btnQuitarFiltroFechas.Click += new System.EventHandler(this.btnQuitarFiltroFechas_Click);
            // 
            // txtFecha2
            // 
            this.txtFecha2.Location = new System.Drawing.Point(171, 419);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(140, 20);
            this.txtFecha2.TabIndex = 132;
            this.txtFecha2.Visible = false;
            // 
            // txtFecha1
            // 
            this.txtFecha1.Location = new System.Drawing.Point(25, 419);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(140, 20);
            this.txtFecha1.TabIndex = 131;
            this.txtFecha1.Visible = false;
            // 
            // lblCreaVista
            // 
            this.lblCreaVista.Location = new System.Drawing.Point(25, 70);
            this.lblCreaVista.Name = "lblCreaVista";
            this.lblCreaVista.Size = new System.Drawing.Size(754, 282);
            this.lblCreaVista.TabIndex = 134;
            this.lblCreaVista.Text = resources.GetString("lblCreaVista.Text");
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 75;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // entradas
            // 
            this.entradas.DataPropertyName = "entradas";
            dataGridViewCellStyle1.NullValue = null;
            this.entradas.DefaultCellStyle = dataGridViewCellStyle1;
            this.entradas.HeaderText = "Entradas";
            this.entradas.Name = "entradas";
            this.entradas.ReadOnly = true;
            this.entradas.Width = 60;
            // 
            // salidas
            // 
            this.salidas.DataPropertyName = "salidas";
            dataGridViewCellStyle2.NullValue = null;
            this.salidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.salidas.HeaderText = "Salidas";
            this.salidas.Name = "salidas";
            this.salidas.ReadOnly = true;
            this.salidas.Width = 60;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "costo";
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 60;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 60;
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.txtFecha2);
            this.Controls.Add(this.txtFecha1);
            this.Controls.Add(this.btnQuitarFiltroFechas);
            this.Controls.Add(this.picturekOk2);
            this.Controls.Add(this.picturekOk1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoReporte);
            this.Controls.Add(this.chkFiltro);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgKardex);
            this.Controls.Add(this.lblCreaVista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturekOk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturekOk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKardex;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.CheckBox chkFiltro;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picturekOk2;
        private System.Windows.Forms.PictureBox picturekOk1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnQuitarFiltroFechas;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.Label lblCreaVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}