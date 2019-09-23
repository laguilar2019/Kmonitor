namespace KMonitor.GUI
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnGroupProducto = new System.Windows.Forms.ToolStrip();
            this.btnProductoNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductoEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductoDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductoSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFiltroProducto = new System.Windows.Forms.ToolStripTextBox();
            this.btnFinal = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventariable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoprod = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblSelectImg = new System.Windows.Forms.Label();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.chkInventariable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.cboPresentacion = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.groupBoxPresentacion = new System.Windows.Forms.GroupBox();
            this.dgPresentacion = new System.Windows.Forms.DataGridView();
            this.btnGroupPrentacion = new System.Windows.Forms.ToolStrip();
            this.btnPresentacionNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPresentacionEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPresentacionDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPresentacionSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPresentacion = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.chkCategoriaActiva = new System.Windows.Forms.CheckBox();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.btnGroupCategoria = new System.Windows.Forms.ToolStrip();
            this.btnCategoriaNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategoriaEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategoriaDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategoriaSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.tabMarca = new System.Windows.Forms.TabPage();
            this.groupBoxTipoProducto = new System.Windows.Forms.GroupBox();
            this.dgTipoProducto = new System.Windows.Forms.DataGridView();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGroupTipoProducto = new System.Windows.Forms.ToolStrip();
            this.btnTipoProductoNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTipoProductoEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTipoProductoDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTipoProductoSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdTipo = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.groupBoxMarca = new System.Windows.Forms.GroupBox();
            this.dgMarcas = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGroupMarca = new System.Windows.Forms.ToolStrip();
            this.btnMarcaNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMarcaEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMarcaDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMarcaSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.idFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProducto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.btnGroupProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.groupBoxProducto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCategoria.SuspendLayout();
            this.groupBoxPresentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacion)).BeginInit();
            this.btnGroupPrentacion.SuspendLayout();
            this.groupBoxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.btnGroupCategoria.SuspendLayout();
            this.tabMarca.SuspendLayout();
            this.groupBoxTipoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoProducto)).BeginInit();
            this.btnGroupTipoProducto.SuspendLayout();
            this.groupBoxMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
            this.btnGroupMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabPage1);
            this.tabProducto.Controls.Add(this.tabCategoria);
            this.tabProducto.Controls.Add(this.tabMarca);
            this.tabProducto.ItemSize = new System.Drawing.Size(58, 28);
            this.tabProducto.Location = new System.Drawing.Point(2, 1);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(937, 438);
            this.tabProducto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtIdProducto);
            this.tabPage1.Controls.Add(this.btnGroupProducto);
            this.tabPage1.Controls.Add(this.btnFinal);
            this.tabPage1.Controls.Add(this.dgProducto);
            this.tabPage1.Controls.Add(this.btnExaminar);
            this.tabPage1.Controls.Add(this.lblSelectImg);
            this.tabPage1.Controls.Add(this.imgProducto);
            this.tabPage1.Controls.Add(this.groupBoxProducto);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.Location = new System.Drawing.Point(607, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 81;
            this.label13.Text = "IdProducto";
            this.label13.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProducto.Location = new System.Drawing.Point(610, 374);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(86, 20);
            this.txtIdProducto.TabIndex = 80;
            this.txtIdProducto.Visible = false;
            // 
            // btnGroupProducto
            // 
            this.btnGroupProducto.AutoSize = false;
            this.btnGroupProducto.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProductoNewSave,
            this.toolStripSeparator17,
            this.btnProductoEditCancel,
            this.toolStripSeparator18,
            this.btnProductoDelete,
            this.toolStripSeparator19,
            this.btnProductoSearch,
            this.toolStripSeparator20,
            this.txtFiltroProducto});
            this.btnGroupProducto.Location = new System.Drawing.Point(69, 358);
            this.btnGroupProducto.Name = "btnGroupProducto";
            this.btnGroupProducto.Size = new System.Drawing.Size(537, 38);
            this.btnGroupProducto.TabIndex = 5;
            this.btnGroupProducto.Text = "toolStrip1";
            // 
            // btnProductoNewSave
            // 
            this.btnProductoNewSave.AutoSize = false;
            this.btnProductoNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnProductoNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductoNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductoNewSave.Name = "btnProductoNewSave";
            this.btnProductoNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnProductoNewSave.Tag = "1";
            this.btnProductoNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoNewSave.Click += new System.EventHandler(this.btnProductoNewSave_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProductoEditCancel
            // 
            this.btnProductoEditCancel.AutoSize = false;
            this.btnProductoEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnProductoEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductoEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductoEditCancel.Name = "btnProductoEditCancel";
            this.btnProductoEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnProductoEditCancel.Tag = "1";
            this.btnProductoEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoEditCancel.Click += new System.EventHandler(this.btnProductoEditCancel_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProductoDelete
            // 
            this.btnProductoDelete.AutoSize = false;
            this.btnProductoDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnProductoDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductoDelete.Name = "btnProductoDelete";
            this.btnProductoDelete.Size = new System.Drawing.Size(36, 58);
            this.btnProductoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoDelete.Click += new System.EventHandler(this.btnProductoDelete_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProductoSearch
            // 
            this.btnProductoSearch.AutoSize = false;
            this.btnProductoSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnProductoSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductoSearch.Name = "btnProductoSearch";
            this.btnProductoSearch.Size = new System.Drawing.Size(36, 58);
            this.btnProductoSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoSearch.Click += new System.EventHandler(this.btnProductoSearch_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.AutoSize = false;
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(46, 36);
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(250, 38);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinal.Image = global::KMonitor.Properties.Resources.flechadown;
            this.btnFinal.Location = new System.Drawing.Point(8, 358);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(45, 34);
            this.btnFinal.TabIndex = 1;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // dgProducto
            // 
            this.dgProducto.AllowUserToDeleteRows = false;
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.descripcion,
            this.precio,
            this.costo,
            this.stock,
            this.stockMinimo,
            this.inventariable,
            this.activoprod});
            this.dgProducto.Location = new System.Drawing.Point(9, 149);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.Size = new System.Drawing.Size(914, 203);
            this.dgProducto.TabIndex = 0;
            this.dgProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducto_CellContentClick);
            this.dgProducto.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgProducto_EditingControlShowing);
            this.dgProducto.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducto_RowLeave);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "Id(auto)";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 70;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Presentación";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 275;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 60;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "costo";
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.Width = 60;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.Width = 65;
            // 
            // stockMinimo
            // 
            this.stockMinimo.DataPropertyName = "stockMinimo";
            this.stockMinimo.HeaderText = "StockMín.";
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.Width = 65;
            // 
            // inventariable
            // 
            this.inventariable.DataPropertyName = "inventariable";
            this.inventariable.HeaderText = "Inventariable";
            this.inventariable.Name = "inventariable";
            this.inventariable.Width = 70;
            // 
            // activoprod
            // 
            this.activoprod.DataPropertyName = "activo";
            this.activoprod.HeaderText = "Activo";
            this.activoprod.Name = "activoprod";
            this.activoprod.Width = 50;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.Transparent;
            this.btnExaminar.Location = new System.Drawing.Point(805, 15);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(87, 23);
            this.btnExaminar.TabIndex = 44;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            // 
            // lblSelectImg
            // 
            this.lblSelectImg.AutoSize = true;
            this.lblSelectImg.Location = new System.Drawing.Point(802, 1);
            this.lblSelectImg.Name = "lblSelectImg";
            this.lblSelectImg.Size = new System.Drawing.Size(42, 13);
            this.lblSelectImg.TabIndex = 46;
            this.lblSelectImg.Text = "Imagen";
            // 
            // imgProducto
            // 
            this.imgProducto.Location = new System.Drawing.Point(804, 44);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(120, 98);
            this.imgProducto.TabIndex = 45;
            this.imgProducto.TabStop = false;
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.chkMostrar);
            this.groupBoxProducto.Controls.Add(this.txtStockMinimo);
            this.groupBoxProducto.Controls.Add(this.lblStockMinimo);
            this.groupBoxProducto.Controls.Add(this.txtStock);
            this.groupBoxProducto.Controls.Add(this.lblStock);
            this.groupBoxProducto.Controls.Add(this.txtPrecio);
            this.groupBoxProducto.Controls.Add(this.lblPrecio);
            this.groupBoxProducto.Controls.Add(this.txtCosto);
            this.groupBoxProducto.Controls.Add(this.lblCosto);
            this.groupBoxProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxProducto.Controls.Add(this.lblDescripcion);
            this.groupBoxProducto.Controls.Add(this.chkInventariable);
            this.groupBoxProducto.Location = new System.Drawing.Point(8, 78);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(791, 66);
            this.groupBoxProducto.TabIndex = 1;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Detalles del producto";
            // 
            // chkMostrar
            // 
            this.chkMostrar.Location = new System.Drawing.Point(691, 15);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(101, 17);
            this.chkMostrar.TabIndex = 5;
            this.chkMostrar.Text = "Mostrar en POS";
            this.chkMostrar.UseVisualStyleBackColor = true;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(618, 27);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.ReadOnly = true;
            this.txtStockMinimo.Size = new System.Drawing.Size(66, 20);
            this.txtStockMinimo.TabIndex = 4;
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMinimo_KeyPress);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AllowDrop = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(615, 10);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(72, 13);
            this.lblStockMinimo.TabIndex = 78;
            this.lblStockMinimo.Text = "Stock Minimo";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(533, 27);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(81, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(530, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 13);
            this.lblStock.TabIndex = 77;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(398, 27);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(62, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(394, 10);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 76;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(466, 27);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(62, 20);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(463, 10);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 13);
            this.lblCosto.TabIndex = 75;
            this.lblCosto.Text = "Costo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(74, 27);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(316, 20);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AllowDrop = true;
            this.lblDescripcion.Location = new System.Drawing.Point(5, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(64, 21);
            this.lblDescripcion.TabIndex = 74;
            this.lblDescripcion.Text = "Descripción";
            // 
            // chkInventariable
            // 
            this.chkInventariable.Location = new System.Drawing.Point(691, 38);
            this.chkInventariable.Name = "chkInventariable";
            this.chkInventariable.Size = new System.Drawing.Size(87, 17);
            this.chkInventariable.TabIndex = 6;
            this.chkInventariable.Text = "Inventariable";
            this.chkInventariable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMarca);
            this.groupBox1.Controls.Add(this.cboTipoProducto);
            this.groupBox1.Controls.Add(this.cboPresentacion);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione las opciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de producto";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(564, 37);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(209, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(420, 37);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(136, 21);
            this.cboTipoProducto.TabIndex = 2;
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(227, 37);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(187, 21);
            this.cboPresentacion.TabIndex = 1;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(27, 37);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(194, 21);
            this.cboCategoria.TabIndex = 0;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.groupBoxPresentacion);
            this.tabCategoria.Controls.Add(this.groupBoxCategoria);
            this.tabCategoria.Location = new System.Drawing.Point(4, 32);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoria.Size = new System.Drawing.Size(929, 402);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categoría y Presentación";
            this.tabCategoria.UseVisualStyleBackColor = true;
            // 
            // groupBoxPresentacion
            // 
            this.groupBoxPresentacion.Controls.Add(this.dgPresentacion);
            this.groupBoxPresentacion.Controls.Add(this.btnGroupPrentacion);
            this.groupBoxPresentacion.Controls.Add(this.label7);
            this.groupBoxPresentacion.Controls.Add(this.label8);
            this.groupBoxPresentacion.Controls.Add(this.txtIdPresentacion);
            this.groupBoxPresentacion.Controls.Add(this.txtPresentacion);
            this.groupBoxPresentacion.Location = new System.Drawing.Point(493, 5);
            this.groupBoxPresentacion.Name = "groupBoxPresentacion";
            this.groupBoxPresentacion.Size = new System.Drawing.Size(413, 387);
            this.groupBoxPresentacion.TabIndex = 0;
            this.groupBoxPresentacion.TabStop = false;
            this.groupBoxPresentacion.Text = "Presentación (unidad de medida)";
            // 
            // dgPresentacion
            // 
            this.dgPresentacion.AllowUserToAddRows = false;
            this.dgPresentacion.AllowUserToDeleteRows = false;
            this.dgPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUnidad,
            this.unidadMedida});
            this.dgPresentacion.Location = new System.Drawing.Point(26, 80);
            this.dgPresentacion.Name = "dgPresentacion";
            this.dgPresentacion.ReadOnly = true;
            this.dgPresentacion.RowHeadersVisible = false;
            this.dgPresentacion.Size = new System.Drawing.Size(364, 291);
            this.dgPresentacion.TabIndex = 20;
            // 
            // btnGroupPrentacion
            // 
            this.btnGroupPrentacion.AutoSize = false;
            this.btnGroupPrentacion.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupPrentacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPresentacionNewSave,
            this.toolStripSeparator5,
            this.btnPresentacionEditCancel,
            this.toolStripSeparator6,
            this.btnPresentacionDelete,
            this.toolStripSeparator7,
            this.btnPresentacionSearch,
            this.toolStripSeparator8});
            this.btnGroupPrentacion.Location = new System.Drawing.Point(187, 12);
            this.btnGroupPrentacion.Name = "btnGroupPrentacion";
            this.btnGroupPrentacion.Size = new System.Drawing.Size(202, 34);
            this.btnGroupPrentacion.TabIndex = 19;
            this.btnGroupPrentacion.Text = "toolStrip1";
            // 
            // btnPresentacionNewSave
            // 
            this.btnPresentacionNewSave.AutoSize = false;
            this.btnPresentacionNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnPresentacionNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPresentacionNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPresentacionNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPresentacionNewSave.Name = "btnPresentacionNewSave";
            this.btnPresentacionNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnPresentacionNewSave.Tag = "1";
            this.btnPresentacionNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresentacionNewSave.Click += new System.EventHandler(this.btnPresentacionNewSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPresentacionEditCancel
            // 
            this.btnPresentacionEditCancel.AutoSize = false;
            this.btnPresentacionEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnPresentacionEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPresentacionEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPresentacionEditCancel.Name = "btnPresentacionEditCancel";
            this.btnPresentacionEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnPresentacionEditCancel.Tag = "1";
            this.btnPresentacionEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresentacionEditCancel.Click += new System.EventHandler(this.btnPresentacionEditCancel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPresentacionDelete
            // 
            this.btnPresentacionDelete.AutoSize = false;
            this.btnPresentacionDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnPresentacionDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPresentacionDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPresentacionDelete.Name = "btnPresentacionDelete";
            this.btnPresentacionDelete.Size = new System.Drawing.Size(36, 58);
            this.btnPresentacionDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresentacionDelete.Click += new System.EventHandler(this.btnPresentacionDelete_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPresentacionSearch
            // 
            this.btnPresentacionSearch.AutoSize = false;
            this.btnPresentacionSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnPresentacionSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPresentacionSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPresentacionSearch.Name = "btnPresentacionSearch";
            this.btnPresentacionSearch.Size = new System.Drawing.Size(36, 58);
            this.btnPresentacionSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPresentacionSearch.Click += new System.EventHandler(this.btnPresentacionSearch_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(46, 36);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Presentación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Id";
            // 
            // txtIdPresentacion
            // 
            this.txtIdPresentacion.Location = new System.Drawing.Point(90, 28);
            this.txtIdPresentacion.Name = "txtIdPresentacion";
            this.txtIdPresentacion.ReadOnly = true;
            this.txtIdPresentacion.Size = new System.Drawing.Size(60, 20);
            this.txtIdPresentacion.TabIndex = 6;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresentacion.Location = new System.Drawing.Point(90, 51);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.ReadOnly = true;
            this.txtPresentacion.Size = new System.Drawing.Size(300, 20);
            this.txtPresentacion.TabIndex = 7;
            this.txtPresentacion.TextChanged += new System.EventHandler(this.txtPresentacion_TextChanged);
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.chkCategoriaActiva);
            this.groupBoxCategoria.Controls.Add(this.dgCategoria);
            this.groupBoxCategoria.Controls.Add(this.btnGroupCategoria);
            this.groupBoxCategoria.Controls.Add(this.label6);
            this.groupBoxCategoria.Controls.Add(this.label5);
            this.groupBoxCategoria.Controls.Add(this.txtIdCategoria);
            this.groupBoxCategoria.Controls.Add(this.txtCategoria);
            this.groupBoxCategoria.Location = new System.Drawing.Point(21, 5);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(413, 387);
            this.groupBoxCategoria.TabIndex = 0;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoría";
            // 
            // chkCategoriaActiva
            // 
            this.chkCategoriaActiva.AutoSize = true;
            this.chkCategoriaActiva.Location = new System.Drawing.Point(333, 53);
            this.chkCategoriaActiva.Name = "chkCategoriaActiva";
            this.chkCategoriaActiva.Size = new System.Drawing.Size(56, 17);
            this.chkCategoriaActiva.TabIndex = 21;
            this.chkCategoriaActiva.Text = "Activo";
            this.chkCategoriaActiva.UseVisualStyleBackColor = true;
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFamilia,
            this.familia,
            this.activo});
            this.dgCategoria.Location = new System.Drawing.Point(18, 80);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersVisible = false;
            this.dgCategoria.Size = new System.Drawing.Size(373, 291);
            this.dgCategoria.TabIndex = 19;
            // 
            // btnGroupCategoria
            // 
            this.btnGroupCategoria.AutoSize = false;
            this.btnGroupCategoria.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategoriaNewSave,
            this.toolStripSeparator1,
            this.btnCategoriaEditCancel,
            this.toolStripSeparator2,
            this.btnCategoriaDelete,
            this.toolStripSeparator4,
            this.btnCategoriaSearch,
            this.toolStripSeparator3});
            this.btnGroupCategoria.Location = new System.Drawing.Point(179, 12);
            this.btnGroupCategoria.Name = "btnGroupCategoria";
            this.btnGroupCategoria.Size = new System.Drawing.Size(211, 34);
            this.btnGroupCategoria.TabIndex = 18;
            this.btnGroupCategoria.Text = "toolStrip1";
            // 
            // btnCategoriaNewSave
            // 
            this.btnCategoriaNewSave.AutoSize = false;
            this.btnCategoriaNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnCategoriaNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoriaNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoriaNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoriaNewSave.Name = "btnCategoriaNewSave";
            this.btnCategoriaNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnCategoriaNewSave.Tag = "1";
            this.btnCategoriaNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoriaNewSave.Click += new System.EventHandler(this.btnCategoriaNewSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnCategoriaEditCancel
            // 
            this.btnCategoriaEditCancel.AutoSize = false;
            this.btnCategoriaEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnCategoriaEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoriaEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoriaEditCancel.Name = "btnCategoriaEditCancel";
            this.btnCategoriaEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnCategoriaEditCancel.Tag = "1";
            this.btnCategoriaEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoriaEditCancel.Click += new System.EventHandler(this.btnCategoriaEditCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnCategoriaDelete
            // 
            this.btnCategoriaDelete.AutoSize = false;
            this.btnCategoriaDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnCategoriaDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoriaDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoriaDelete.Name = "btnCategoriaDelete";
            this.btnCategoriaDelete.Size = new System.Drawing.Size(36, 58);
            this.btnCategoriaDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoriaDelete.Click += new System.EventHandler(this.btnCategoriaDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btnCategoriaSearch
            // 
            this.btnCategoriaSearch.AutoSize = false;
            this.btnCategoriaSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnCategoriaSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoriaSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoriaSearch.Name = "btnCategoriaSearch";
            this.btnCategoriaSearch.Size = new System.Drawing.Size(36, 58);
            this.btnCategoriaSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoriaSearch.Click += new System.EventHandler(this.btnCategoriaSearch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(46, 36);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(71, 27);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.ReadOnly = true;
            this.txtIdCategoria.Size = new System.Drawing.Size(60, 20);
            this.txtIdCategoria.TabIndex = 2;
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(71, 51);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(252, 20);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // tabMarca
            // 
            this.tabMarca.Controls.Add(this.groupBoxTipoProducto);
            this.tabMarca.Controls.Add(this.groupBoxMarca);
            this.tabMarca.Location = new System.Drawing.Point(4, 32);
            this.tabMarca.Name = "tabMarca";
            this.tabMarca.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarca.Size = new System.Drawing.Size(929, 402);
            this.tabMarca.TabIndex = 2;
            this.tabMarca.Text = "Marcas";
            this.tabMarca.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoProducto
            // 
            this.groupBoxTipoProducto.Controls.Add(this.dgTipoProducto);
            this.groupBoxTipoProducto.Controls.Add(this.btnGroupTipoProducto);
            this.groupBoxTipoProducto.Controls.Add(this.label9);
            this.groupBoxTipoProducto.Controls.Add(this.label10);
            this.groupBoxTipoProducto.Controls.Add(this.txtIdTipo);
            this.groupBoxTipoProducto.Controls.Add(this.txtTipoProducto);
            this.groupBoxTipoProducto.Location = new System.Drawing.Point(494, 7);
            this.groupBoxTipoProducto.Name = "groupBoxTipoProducto";
            this.groupBoxTipoProducto.Size = new System.Drawing.Size(413, 385);
            this.groupBoxTipoProducto.TabIndex = 1;
            this.groupBoxTipoProducto.TabStop = false;
            this.groupBoxTipoProducto.Text = "Tipo de productos";
            // 
            // dgTipoProducto
            // 
            this.dgTipoProducto.AllowUserToAddRows = false;
            this.dgTipoProducto.AllowUserToDeleteRows = false;
            this.dgTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipo,
            this.tipo_producto});
            this.dgTipoProducto.Location = new System.Drawing.Point(26, 82);
            this.dgTipoProducto.Name = "dgTipoProducto";
            this.dgTipoProducto.ReadOnly = true;
            this.dgTipoProducto.RowHeadersVisible = false;
            this.dgTipoProducto.Size = new System.Drawing.Size(364, 290);
            this.dgTipoProducto.TabIndex = 20;
            // 
            // idTipo
            // 
            this.idTipo.DataPropertyName = "idTipo";
            this.idTipo.HeaderText = "Id";
            this.idTipo.Name = "idTipo";
            this.idTipo.ReadOnly = true;
            this.idTipo.Width = 65;
            // 
            // tipo_producto
            // 
            this.tipo_producto.DataPropertyName = "tipo_producto";
            this.tipo_producto.HeaderText = "Tipo de producto";
            this.tipo_producto.Name = "tipo_producto";
            this.tipo_producto.ReadOnly = true;
            this.tipo_producto.Width = 275;
            // 
            // btnGroupTipoProducto
            // 
            this.btnGroupTipoProducto.AutoSize = false;
            this.btnGroupTipoProducto.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupTipoProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTipoProductoNewSave,
            this.toolStripSeparator9,
            this.btnTipoProductoEditCancel,
            this.toolStripSeparator10,
            this.btnTipoProductoDelete,
            this.toolStripSeparator11,
            this.btnTipoProductoSearch,
            this.toolStripSeparator12});
            this.btnGroupTipoProducto.Location = new System.Drawing.Point(198, 12);
            this.btnGroupTipoProducto.Name = "btnGroupTipoProducto";
            this.btnGroupTipoProducto.Size = new System.Drawing.Size(190, 34);
            this.btnGroupTipoProducto.TabIndex = 19;
            this.btnGroupTipoProducto.Text = "toolStrip1";
            // 
            // btnTipoProductoNewSave
            // 
            this.btnTipoProductoNewSave.AutoSize = false;
            this.btnTipoProductoNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnTipoProductoNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoProductoNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTipoProductoNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTipoProductoNewSave.Name = "btnTipoProductoNewSave";
            this.btnTipoProductoNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnTipoProductoNewSave.Tag = "1";
            this.btnTipoProductoNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoProductoNewSave.Click += new System.EventHandler(this.btnTipoProductoNewSave_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 34);
            // 
            // btnTipoProductoEditCancel
            // 
            this.btnTipoProductoEditCancel.AutoSize = false;
            this.btnTipoProductoEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnTipoProductoEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTipoProductoEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTipoProductoEditCancel.Name = "btnTipoProductoEditCancel";
            this.btnTipoProductoEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnTipoProductoEditCancel.Tag = "1";
            this.btnTipoProductoEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoProductoEditCancel.Click += new System.EventHandler(this.btnTipoProductoEditCancel_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 34);
            // 
            // btnTipoProductoDelete
            // 
            this.btnTipoProductoDelete.AutoSize = false;
            this.btnTipoProductoDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnTipoProductoDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTipoProductoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTipoProductoDelete.Name = "btnTipoProductoDelete";
            this.btnTipoProductoDelete.Size = new System.Drawing.Size(36, 58);
            this.btnTipoProductoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoProductoDelete.Click += new System.EventHandler(this.btnTipoProductoDelete_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 34);
            // 
            // btnTipoProductoSearch
            // 
            this.btnTipoProductoSearch.AutoSize = false;
            this.btnTipoProductoSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnTipoProductoSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTipoProductoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTipoProductoSearch.Name = "btnTipoProductoSearch";
            this.btnTipoProductoSearch.Size = new System.Drawing.Size(36, 58);
            this.btnTipoProductoSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoProductoSearch.Click += new System.EventHandler(this.btnTipoProductoSearch_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.AutoSize = false;
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(46, 36);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo de producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Id";
            // 
            // txtIdTipo
            // 
            this.txtIdTipo.Location = new System.Drawing.Point(106, 25);
            this.txtIdTipo.Name = "txtIdTipo";
            this.txtIdTipo.ReadOnly = true;
            this.txtIdTipo.Size = new System.Drawing.Size(60, 20);
            this.txtIdTipo.TabIndex = 6;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoProducto.Location = new System.Drawing.Point(106, 51);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.ReadOnly = true;
            this.txtTipoProducto.Size = new System.Drawing.Size(284, 20);
            this.txtTipoProducto.TabIndex = 7;
            this.txtTipoProducto.TextChanged += new System.EventHandler(this.txtTipoProducto_TextChanged);
            // 
            // groupBoxMarca
            // 
            this.groupBoxMarca.Controls.Add(this.dgMarcas);
            this.groupBoxMarca.Controls.Add(this.btnGroupMarca);
            this.groupBoxMarca.Controls.Add(this.label11);
            this.groupBoxMarca.Controls.Add(this.label12);
            this.groupBoxMarca.Controls.Add(this.txtIdMarca);
            this.groupBoxMarca.Controls.Add(this.txtMarca);
            this.groupBoxMarca.Location = new System.Drawing.Point(22, 7);
            this.groupBoxMarca.Name = "groupBoxMarca";
            this.groupBoxMarca.Size = new System.Drawing.Size(413, 385);
            this.groupBoxMarca.TabIndex = 2;
            this.groupBoxMarca.TabStop = false;
            this.groupBoxMarca.Text = "Marcas de productos";
            // 
            // dgMarcas
            // 
            this.dgMarcas.AllowUserToAddRows = false;
            this.dgMarcas.AllowUserToDeleteRows = false;
            this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.marca});
            this.dgMarcas.Location = new System.Drawing.Point(18, 82);
            this.dgMarcas.Name = "dgMarcas";
            this.dgMarcas.ReadOnly = true;
            this.dgMarcas.RowHeadersVisible = false;
            this.dgMarcas.Size = new System.Drawing.Size(373, 290);
            this.dgMarcas.TabIndex = 19;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idMarca";
            this.idMarca.HeaderText = "Id";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Width = 70;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 275;
            // 
            // btnGroupMarca
            // 
            this.btnGroupMarca.AutoSize = false;
            this.btnGroupMarca.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMarcaNewSave,
            this.toolStripSeparator13,
            this.btnMarcaEditCancel,
            this.toolStripSeparator14,
            this.btnMarcaDelete,
            this.toolStripSeparator15,
            this.btnMarcaSearch,
            this.toolStripSeparator16});
            this.btnGroupMarca.Location = new System.Drawing.Point(181, 12);
            this.btnGroupMarca.Name = "btnGroupMarca";
            this.btnGroupMarca.Size = new System.Drawing.Size(208, 34);
            this.btnGroupMarca.TabIndex = 18;
            this.btnGroupMarca.Text = "toolStrip1";
            // 
            // btnMarcaNewSave
            // 
            this.btnMarcaNewSave.AutoSize = false;
            this.btnMarcaNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnMarcaNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcaNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMarcaNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcaNewSave.Name = "btnMarcaNewSave";
            this.btnMarcaNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnMarcaNewSave.Tag = "1";
            this.btnMarcaNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcaNewSave.Click += new System.EventHandler(this.btnMarcaNewSave_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 34);
            // 
            // btnMarcaEditCancel
            // 
            this.btnMarcaEditCancel.AutoSize = false;
            this.btnMarcaEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnMarcaEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMarcaEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcaEditCancel.Name = "btnMarcaEditCancel";
            this.btnMarcaEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnMarcaEditCancel.Tag = "1";
            this.btnMarcaEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcaEditCancel.Click += new System.EventHandler(this.btnMarcaEditCancel_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 34);
            // 
            // btnMarcaDelete
            // 
            this.btnMarcaDelete.AutoSize = false;
            this.btnMarcaDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnMarcaDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMarcaDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcaDelete.Name = "btnMarcaDelete";
            this.btnMarcaDelete.Size = new System.Drawing.Size(36, 58);
            this.btnMarcaDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcaDelete.Click += new System.EventHandler(this.btnMarcaDelete_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 34);
            // 
            // btnMarcaSearch
            // 
            this.btnMarcaSearch.AutoSize = false;
            this.btnMarcaSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnMarcaSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMarcaSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarcaSearch.Name = "btnMarcaSearch";
            this.btnMarcaSearch.Size = new System.Drawing.Size(36, 58);
            this.btnMarcaSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcaSearch.Click += new System.EventHandler(this.btnMarcaSearch_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.AutoSize = false;
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(46, 36);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Marcas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Id";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(82, 25);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.ReadOnly = true;
            this.txtIdMarca.Size = new System.Drawing.Size(60, 20);
            this.txtIdMarca.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(82, 51);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(309, 20);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // idFamilia
            // 
            this.idFamilia.DataPropertyName = "idFamilia";
            this.idFamilia.HeaderText = "Id";
            this.idFamilia.Name = "idFamilia";
            this.idFamilia.ReadOnly = true;
            this.idFamilia.Width = 70;
            // 
            // familia
            // 
            this.familia.DataPropertyName = "familia";
            this.familia.HeaderText = "Categoria";
            this.familia.Name = "familia";
            this.familia.ReadOnly = true;
            this.familia.Width = 225;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 50;
            // 
            // idUnidad
            // 
            this.idUnidad.DataPropertyName = "idUnidad";
            this.idUnidad.HeaderText = "Id";
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.ReadOnly = true;
            this.idUnidad.Width = 65;
            // 
            // unidadMedida
            // 
            this.unidadMedida.DataPropertyName = "unidadMedida";
            this.unidadMedida.HeaderText = "Presentación";
            this.unidadMedida.Name = "unidadMedida";
            this.unidadMedida.ReadOnly = true;
            this.unidadMedida.Width = 275;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(940, 451);
            this.Controls.Add(this.tabProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.tabProducto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.btnGroupProducto.ResumeLayout(false);
            this.btnGroupProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCategoria.ResumeLayout(false);
            this.groupBoxPresentacion.ResumeLayout(false);
            this.groupBoxPresentacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacion)).EndInit();
            this.btnGroupPrentacion.ResumeLayout(false);
            this.btnGroupPrentacion.PerformLayout();
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.btnGroupCategoria.ResumeLayout(false);
            this.btnGroupCategoria.PerformLayout();
            this.tabMarca.ResumeLayout(false);
            this.groupBoxTipoProducto.ResumeLayout(false);
            this.groupBoxTipoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoProducto)).EndInit();
            this.btnGroupTipoProducto.ResumeLayout(false);
            this.btnGroupTipoProducto.PerformLayout();
            this.groupBoxMarca.ResumeLayout(false);
            this.groupBoxMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
            this.btnGroupMarca.ResumeLayout(false);
            this.btnGroupMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.CheckBox chkInventariable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.ComboBox cboPresentacion;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.TabPage tabMarca;
        private System.Windows.Forms.GroupBox groupBoxPresentacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdPresentacion;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.ToolStrip btnGroupCategoria;
        private System.Windows.Forms.ToolStripButton btnCategoriaNewSave;
        private System.Windows.Forms.ToolStripButton btnCategoriaEditCancel;
        private System.Windows.Forms.ToolStripButton btnCategoriaDelete;
        private System.Windows.Forms.ToolStripButton btnCategoriaSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip btnGroupPrentacion;
        private System.Windows.Forms.ToolStripButton btnPresentacionNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnPresentacionEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnPresentacionDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnPresentacionSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.DataGridView dgPresentacion;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblSelectImg;
        private System.Windows.Forms.PictureBox imgProducto;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.GroupBox groupBoxTipoProducto;
        private System.Windows.Forms.DataGridView dgTipoProducto;
        private System.Windows.Forms.ToolStrip btnGroupTipoProducto;
        private System.Windows.Forms.ToolStripButton btnTipoProductoNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnTipoProductoEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnTipoProductoDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btnTipoProductoSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdTipo;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.GroupBox groupBoxMarca;
        private System.Windows.Forms.DataGridView dgMarcas;
        private System.Windows.Forms.ToolStrip btnGroupMarca;
        private System.Windows.Forms.ToolStripButton btnMarcaNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton btnMarcaEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton btnMarcaDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton btnMarcaSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox chkCategoriaActiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inventariable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoprod;
        private System.Windows.Forms.ToolStrip btnGroupProducto;
        private System.Windows.Forms.ToolStripButton btnProductoNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton btnProductoEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripButton btnProductoDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripButton btnProductoSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripTextBox txtFiltroProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
    }
}