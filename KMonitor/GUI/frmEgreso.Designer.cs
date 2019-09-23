namespace KMonitor.GUI
{
    partial class frmEgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEgreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.btnQueryInforme = new System.Windows.Forms.Button();
            this.btnFechasConsolidado = new System.Windows.Forms.Button();
            this.btnReporteFechas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQueryIDCaja = new System.Windows.Forms.TextBox();
            this.dgQuery = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nReferencia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtFecha2 = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtFecha1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.txtNreferencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTIpoEgreso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuFamilia = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnInforme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdCaja = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEfectivoDisponible = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCaantidad = new System.Windows.Forms.Label();
            this.dgEgreso = new System.Windows.Forms.DataGridView();
            this.idEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEgresoTipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalirTipoEgreso = new System.Windows.Forms.Button();
            this.groupBoxTipoEgreso = new System.Windows.Forms.GroupBox();
            this.dgEgresoTipo = new System.Windows.Forms.DataGridView();
            this.idEgresoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGroupCategoria = new System.Windows.Forms.ToolStrip();
            this.btnNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdEgresoTipo = new System.Windows.Forms.TextBox();
            this.txtEgresoTipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.menuFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgreso)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxTipoEgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresoTipo)).BeginInit();
            this.btnGroupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // temporizador
            // 
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.btnQueryInforme);
            this.tabCaja.Controls.Add(this.btnFechasConsolidado);
            this.tabCaja.Controls.Add(this.btnReporteFechas);
            this.tabCaja.Controls.Add(this.label4);
            this.tabCaja.Controls.Add(this.txtQueryIDCaja);
            this.tabCaja.Controls.Add(this.dgQuery);
            this.tabCaja.Controls.Add(this.label1);
            this.tabCaja.Controls.Add(this.label3);
            this.tabCaja.Controls.Add(this.dateEnd);
            this.tabCaja.Controls.Add(this.txtFecha2);
            this.tabCaja.Controls.Add(this.dateStart);
            this.tabCaja.Controls.Add(this.txtFecha1);
            this.tabCaja.Controls.Add(this.btnExit);
            this.tabCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCaja.Location = new System.Drawing.Point(4, 34);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(773, 481);
            this.tabCaja.TabIndex = 3;
            this.tabCaja.Text = "Consultar egresos";
            this.tabCaja.UseVisualStyleBackColor = true;
            // 
            // btnQueryInforme
            // 
            this.btnQueryInforme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQueryInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryInforme.Image")));
            this.btnQueryInforme.Location = new System.Drawing.Point(425, 398);
            this.btnQueryInforme.Name = "btnQueryInforme";
            this.btnQueryInforme.Size = new System.Drawing.Size(175, 67);
            this.btnQueryInforme.TabIndex = 10;
            this.btnQueryInforme.Text = "Informe Completo";
            this.btnQueryInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQueryInforme.UseVisualStyleBackColor = false;
            this.btnQueryInforme.Click += new System.EventHandler(this.btnQueryInforme_Click);
            // 
            // btnFechasConsolidado
            // 
            this.btnFechasConsolidado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechasConsolidado.Image = ((System.Drawing.Image)(resources.GetObject("btnFechasConsolidado.Image")));
            this.btnFechasConsolidado.Location = new System.Drawing.Point(605, 397);
            this.btnFechasConsolidado.Name = "btnFechasConsolidado";
            this.btnFechasConsolidado.Size = new System.Drawing.Size(152, 67);
            this.btnFechasConsolidado.TabIndex = 65;
            this.btnFechasConsolidado.Text = "Resumen mensual";
            this.btnFechasConsolidado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechasConsolidado.UseVisualStyleBackColor = false;
            this.btnFechasConsolidado.Click += new System.EventHandler(this.btnFechasConsolidado_Click);
            // 
            // btnReporteFechas
            // 
            this.btnReporteFechas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporteFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteFechas.Image")));
            this.btnReporteFechas.Location = new System.Drawing.Point(267, 398);
            this.btnReporteFechas.Name = "btnReporteFechas";
            this.btnReporteFechas.Size = new System.Drawing.Size(152, 67);
            this.btnReporteFechas.TabIndex = 64;
            this.btnReporteFechas.Text = "Detalle mensual";
            this.btnReporteFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporteFechas.UseVisualStyleBackColor = false;
            this.btnReporteFechas.Click += new System.EventHandler(this.btnReporteFechas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Filtrar por ID caja";
            // 
            // txtQueryIDCaja
            // 
            this.txtQueryIDCaja.Location = new System.Drawing.Point(122, 420);
            this.txtQueryIDCaja.Name = "txtQueryIDCaja";
            this.txtQueryIDCaja.Size = new System.Drawing.Size(86, 21);
            this.txtQueryIDCaja.TabIndex = 62;
            this.txtQueryIDCaja.TextChanged += new System.EventHandler(this.txtQueryIDCaja_TextChanged);
            // 
            // dgQuery
            // 
            this.dgQuery.AllowUserToAddRows = false;
            this.dgQuery.AllowUserToDeleteRows = false;
            this.dgQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.fecha,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.nReferencia2,
            this.idUsuario2});
            this.dgQuery.Location = new System.Drawing.Point(17, 90);
            this.dgQuery.Name = "dgQuery";
            this.dgQuery.ReadOnly = true;
            this.dgQuery.Size = new System.Drawing.Size(740, 290);
            this.dgQuery.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEgreso";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEgreso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCaja";
            this.dataGridViewTextBoxColumn2.HeaderText = "idCaja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descriopción / Justificación";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // nReferencia2
            // 
            this.nReferencia2.DataPropertyName = "nReferencia";
            this.nReferencia2.HeaderText = "# Referencia";
            this.nReferencia2.Name = "nReferencia2";
            this.nReferencia2.ReadOnly = true;
            // 
            // idUsuario2
            // 
            this.idUsuario2.DataPropertyName = "idUsuario";
            this.idUsuario2.HeaderText = "Usuario";
            this.idUsuario2.Name = "idUsuario2";
            this.idUsuario2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Desde";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(81, 51);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 21);
            this.dateEnd.TabIndex = 14;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // txtFecha2
            // 
            this.txtFecha2.Location = new System.Drawing.Point(128, 447);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.Size = new System.Drawing.Size(105, 21);
            this.txtFecha2.TabIndex = 13;
            this.txtFecha2.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(81, 23);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 21);
            this.dateStart.TabIndex = 12;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // txtFecha1
            // 
            this.txtFecha1.Location = new System.Drawing.Point(17, 447);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(105, 21);
            this.txtFecha1.TabIndex = 11;
            this.txtFecha1.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = global::KMonitor.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(643, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 70);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Salir";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.txtNreferencia);
            this.tabConfig.Controls.Add(this.label8);
            this.tabConfig.Controls.Add(this.cboTIpoEgreso);
            this.tabConfig.Controls.Add(this.label7);
            this.tabConfig.Controls.Add(this.menuFamilia);
            this.tabConfig.Controls.Add(this.lblUsuario);
            this.tabConfig.Controls.Add(this.txtUsuario);
            this.tabConfig.Controls.Add(this.txtDescripcion);
            this.tabConfig.Controls.Add(this.txtCantidad);
            this.tabConfig.Controls.Add(this.txtIdCaja);
            this.tabConfig.Controls.Add(this.txtId);
            this.tabConfig.Controls.Add(this.lblEfectivoDisponible);
            this.tabConfig.Controls.Add(this.lblMenu);
            this.tabConfig.Controls.Add(this.lblDescripcion);
            this.tabConfig.Controls.Add(this.txtFecha);
            this.tabConfig.Controls.Add(this.lblFecha);
            this.tabConfig.Controls.Add(this.lblCaantidad);
            this.tabConfig.Controls.Add(this.dgEgreso);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.lblID);
            this.tabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConfig.Location = new System.Drawing.Point(4, 34);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(773, 481);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Egresos de efectivo";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // txtNreferencia
            // 
            this.txtNreferencia.Location = new System.Drawing.Point(457, 58);
            this.txtNreferencia.Name = "txtNreferencia";
            this.txtNreferencia.Size = new System.Drawing.Size(211, 20);
            this.txtNreferencia.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "# de referencia";
            // 
            // cboTIpoEgreso
            // 
            this.cboTIpoEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTIpoEgreso.FormattingEnabled = true;
            this.cboTIpoEgreso.Location = new System.Drawing.Point(151, 58);
            this.cboTIpoEgreso.Name = "cboTIpoEgreso";
            this.cboTIpoEgreso.Size = new System.Drawing.Size(289, 21);
            this.cboTIpoEgreso.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Tipo de egreso";
            // 
            // menuFamilia
            // 
            this.menuFamilia.AutoSize = false;
            this.menuFamilia.Dock = System.Windows.Forms.DockStyle.None;
            this.menuFamilia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuFamilia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnModificar,
            this.btnInforme,
            this.toolStripSeparator2,
            this.btnSalir});
            this.menuFamilia.Location = new System.Drawing.Point(3, 416);
            this.menuFamilia.Name = "menuFamilia";
            this.menuFamilia.Size = new System.Drawing.Size(767, 55);
            this.menuFamilia.TabIndex = 46;
            this.menuFamilia.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 40);
            this.btnNuevo.Text = "&Limpiar";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 40);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 40);
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 40);
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.AutoSize = false;
            this.btnInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnInforme.Image")));
            this.btnInforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInforme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(95, 40);
            this.btnInforme.Text = " &Imprimir";
            this.btnInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(94, 40);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 40);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(139, 457);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 70;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(191, 454);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(110, 20);
            this.txtUsuario.TabIndex = 69;
            this.txtUsuario.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(221, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(447, 20);
            this.txtDescripcion.TabIndex = 66;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(674, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 20);
            this.txtCantidad.TabIndex = 61;
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // txtIdCaja
            // 
            this.txtIdCaja.Location = new System.Drawing.Point(61, 454);
            this.txtIdCaja.Name = "txtIdCaja";
            this.txtIdCaja.ReadOnly = true;
            this.txtIdCaja.Size = new System.Drawing.Size(52, 20);
            this.txtIdCaja.TabIndex = 59;
            this.txtIdCaja.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(13, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 58;
            // 
            // lblEfectivoDisponible
            // 
            this.lblEfectivoDisponible.AutoSize = true;
            this.lblEfectivoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEfectivoDisponible.Location = new System.Drawing.Point(241, 9);
            this.lblEfectivoDisponible.Name = "lblEfectivoDisponible";
            this.lblEfectivoDisponible.Size = new System.Drawing.Size(29, 31);
            this.lblEfectivoDisponible.TabIndex = 68;
            this.lblEfectivoDisponible.Text = "$";
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMenu.Location = new System.Drawing.Point(16, 6);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(230, 39);
            this.lblMenu.TabIndex = 67;
            this.lblMenu.Text = "EFECTIVO EN CAJA $";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(218, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 13);
            this.lblDescripcion.TabIndex = 65;
            this.lblDescripcion.Text = "Breve descripción";
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(75, 101);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(140, 20);
            this.txtFecha.TabIndex = 64;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(72, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 63;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCaantidad
            // 
            this.lblCaantidad.AutoSize = true;
            this.lblCaantidad.Location = new System.Drawing.Point(671, 85);
            this.lblCaantidad.Name = "lblCaantidad";
            this.lblCaantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCaantidad.TabIndex = 62;
            this.lblCaantidad.Text = "Cantidad";
            // 
            // dgEgreso
            // 
            this.dgEgreso.AllowUserToAddRows = false;
            this.dgEgreso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEgreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEgreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEgreso,
            this.idCaja,
            this.descripcion,
            this.fecha2,
            this.cantidad,
            this.nReferencia,
            this.idUsuario,
            this.idEgresoTipo2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEgreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEgreso.Location = new System.Drawing.Point(13, 129);
            this.dgEgreso.Name = "dgEgreso";
            this.dgEgreso.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEgreso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEgreso.Size = new System.Drawing.Size(740, 279);
            this.dgEgreso.TabIndex = 60;
            // 
            // idEgreso
            // 
            this.idEgreso.DataPropertyName = "idEgreso";
            this.idEgreso.HeaderText = "idEgreso";
            this.idEgreso.Name = "idEgreso";
            this.idEgreso.ReadOnly = true;
            this.idEgreso.Width = 50;
            // 
            // idCaja
            // 
            this.idCaja.DataPropertyName = "idCaja";
            this.idCaja.HeaderText = "idCaja";
            this.idCaja.Name = "idCaja";
            this.idCaja.ReadOnly = true;
            this.idCaja.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descriopción / Justificación";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 300;
            // 
            // fecha2
            // 
            this.fecha2.DataPropertyName = "fecha";
            this.fecha2.HeaderText = "Fecha";
            this.fecha2.Name = "fecha2";
            this.fecha2.ReadOnly = true;
            this.fecha2.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // nReferencia
            // 
            this.nReferencia.DataPropertyName = "nReferencia";
            this.nReferencia.HeaderText = "# Referencia";
            this.nReferencia.Name = "nReferencia";
            this.nReferencia.ReadOnly = true;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Width = 50;
            // 
            // idEgresoTipo2
            // 
            this.idEgresoTipo2.DataPropertyName = "idEgresoTipo";
            this.idEgresoTipo2.HeaderText = "Tipo de egreso";
            this.idEgresoTipo2.Name = "idEgresoTipo2";
            this.idEgresoTipo2.ReadOnly = true;
            this.idEgresoTipo2.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Caja";
            this.label2.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(49, 13);
            this.lblID.TabIndex = 56;
            this.lblID.Text = "ID (Auto)";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Controls.Add(this.tabCaja);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(400, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 519);
            this.tabControl.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalirTipoEgreso);
            this.tabPage1.Controls.Add(this.groupBoxTipoEgreso);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(773, 481);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Tipos de egresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalirTipoEgreso
            // 
            this.btnSalirTipoEgreso.Location = new System.Drawing.Point(129, 397);
            this.btnSalirTipoEgreso.Name = "btnSalirTipoEgreso";
            this.btnSalirTipoEgreso.Size = new System.Drawing.Size(532, 41);
            this.btnSalirTipoEgreso.TabIndex = 3;
            this.btnSalirTipoEgreso.Text = "Salir";
            this.btnSalirTipoEgreso.UseVisualStyleBackColor = true;
            this.btnSalirTipoEgreso.Click += new System.EventHandler(this.btnSalirTipoEgreso_Click);
            // 
            // groupBoxTipoEgreso
            // 
            this.groupBoxTipoEgreso.Controls.Add(this.dgEgresoTipo);
            this.groupBoxTipoEgreso.Controls.Add(this.btnGroupCategoria);
            this.groupBoxTipoEgreso.Controls.Add(this.label6);
            this.groupBoxTipoEgreso.Controls.Add(this.label5);
            this.groupBoxTipoEgreso.Controls.Add(this.txtIdEgresoTipo);
            this.groupBoxTipoEgreso.Controls.Add(this.txtEgresoTipo);
            this.groupBoxTipoEgreso.Location = new System.Drawing.Point(108, 44);
            this.groupBoxTipoEgreso.Name = "groupBoxTipoEgreso";
            this.groupBoxTipoEgreso.Size = new System.Drawing.Size(577, 329);
            this.groupBoxTipoEgreso.TabIndex = 2;
            this.groupBoxTipoEgreso.TabStop = false;
            this.groupBoxTipoEgreso.Text = "Categorías de egresos";
            // 
            // dgEgresoTipo
            // 
            this.dgEgresoTipo.AllowUserToAddRows = false;
            this.dgEgresoTipo.AllowUserToDeleteRows = false;
            this.dgEgresoTipo.ColumnHeadersHeight = 30;
            this.dgEgresoTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEgresoTipo,
            this.egresoTipo});
            this.dgEgresoTipo.Location = new System.Drawing.Point(21, 81);
            this.dgEgresoTipo.Name = "dgEgresoTipo";
            this.dgEgresoTipo.ReadOnly = true;
            this.dgEgresoTipo.RowHeadersVisible = false;
            this.dgEgresoTipo.RowTemplate.Height = 30;
            this.dgEgresoTipo.Size = new System.Drawing.Size(532, 230);
            this.dgEgresoTipo.TabIndex = 19;
            // 
            // idEgresoTipo
            // 
            this.idEgresoTipo.DataPropertyName = "idEgresoTipo";
            this.idEgresoTipo.HeaderText = "Id";
            this.idEgresoTipo.Name = "idEgresoTipo";
            this.idEgresoTipo.ReadOnly = true;
            this.idEgresoTipo.Width = 70;
            // 
            // egresoTipo
            // 
            this.egresoTipo.DataPropertyName = "egresoTipo";
            this.egresoTipo.HeaderText = "Tipo de egreso";
            this.egresoTipo.Name = "egresoTipo";
            this.egresoTipo.ReadOnly = true;
            this.egresoTipo.Width = 375;
            // 
            // btnGroupCategoria
            // 
            this.btnGroupCategoria.AutoSize = false;
            this.btnGroupCategoria.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewSave,
            this.toolStripSeparator1,
            this.btnEditCancel,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnSearch,
            this.toolStripSeparator5});
            this.btnGroupCategoria.Location = new System.Drawing.Point(224, 12);
            this.btnGroupCategoria.Name = "btnGroupCategoria";
            this.btnGroupCategoria.Size = new System.Drawing.Size(211, 34);
            this.btnGroupCategoria.TabIndex = 18;
            this.btnGroupCategoria.Text = "toolStrip1";
            // 
            // btnNewSave
            // 
            this.btnNewSave.AutoSize = false;
            this.btnNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnNewSave.Tag = "1";
            this.btnNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.AutoSize = false;
            this.btnEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnEditCancel.Tag = "1";
            this.btnEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 58);
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.Image = global::KMonitor.Properties.Resources.search;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 58);
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(46, 36);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de egreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id";
            // 
            // txtIdEgresoTipo
            // 
            this.txtIdEgresoTipo.Location = new System.Drawing.Point(143, 24);
            this.txtIdEgresoTipo.Name = "txtIdEgresoTipo";
            this.txtIdEgresoTipo.ReadOnly = true;
            this.txtIdEgresoTipo.Size = new System.Drawing.Size(60, 24);
            this.txtIdEgresoTipo.TabIndex = 2;
            // 
            // txtEgresoTipo
            // 
            this.txtEgresoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEgresoTipo.Location = new System.Drawing.Point(143, 51);
            this.txtEgresoTipo.Name = "txtEgresoTipo";
            this.txtEgresoTipo.ReadOnly = true;
            this.txtEgresoTipo.Size = new System.Drawing.Size(410, 24);
            this.txtEgresoTipo.TabIndex = 3;
            this.txtEgresoTipo.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // frmEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 519);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos de efectivo";
            this.Load += new System.EventHandler(this.frmEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.tabCaja.ResumeLayout(false);
            this.tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuery)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.menuFamilia.ResumeLayout(false);
            this.menuFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgreso)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxTipoEgreso.ResumeLayout(false);
            this.groupBoxTipoEgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresoTipo)).EndInit();
            this.btnGroupCategoria.ResumeLayout(false);
            this.btnGroupCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdCaja;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEfectivoDisponible;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCaantidad;
        private System.Windows.Forms.DataGridView dgEgreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStrip menuFamilia;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TabPage tabCaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQueryIDCaja;
        private System.Windows.Forms.DataGridView dgQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.Button btnQueryInforme;
        private System.Windows.Forms.ToolStripButton btnInforme;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalirTipoEgreso;
        private System.Windows.Forms.GroupBox groupBoxTipoEgreso;
        private System.Windows.Forms.DataGridView dgEgresoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgresoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresoTipo;
        private System.Windows.Forms.ToolStrip btnGroupCategoria;
        private System.Windows.Forms.ToolStripButton btnNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEgresoTipo;
        private System.Windows.Forms.TextBox txtEgresoTipo;
        private System.Windows.Forms.ComboBox cboTIpoEgreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReporteFechas;
        private System.Windows.Forms.Button btnFechasConsolidado;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox txtNreferencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgresoTipo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nReferencia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario2;
    }
}