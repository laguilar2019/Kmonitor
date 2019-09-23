namespace KMonitor.GUI
{
    partial class frmPermisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisos));
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabPermisos = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOtorgados = new System.Windows.Forms.DataGridView();
            this.idComandoOtorgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandoOtorgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRevocar = new System.Windows.Forms.Button();
            this.btnOtorgar = new System.Windows.Forms.Button();
            this.dgDisponibles = new System.Windows.Forms.DataGridView();
            this.idComandoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPerfilesComandos = new System.Windows.Forms.TabPage();
            this.groupBoxComando = new System.Windows.Forms.GroupBox();
            this.dgComando = new System.Windows.Forms.DataGridView();
            this.idComando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGroupComando = new System.Windows.Forms.ToolStrip();
            this.btnComandoNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnComandoEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnComandoDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtComandoFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdComando = new System.Windows.Forms.TextBox();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.groupBoxPerfil = new System.Windows.Forms.GroupBox();
            this.dgPerfil = new System.Windows.Forms.DataGridView();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGroupPerfil = new System.Windows.Forms.ToolStrip();
            this.btnPerfilNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPerfilEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPerfilDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPerfilFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPerfil = new System.Windows.Forms.TextBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.tabProducto.SuspendLayout();
            this.tabPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtorgados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisponibles)).BeginInit();
            this.tabPerfilesComandos.SuspendLayout();
            this.groupBoxComando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComando)).BeginInit();
            this.btnGroupComando.SuspendLayout();
            this.groupBoxPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfil)).BeginInit();
            this.btnGroupPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabPermisos);
            this.tabProducto.Controls.Add(this.tabPerfilesComandos);
            this.tabProducto.ItemSize = new System.Drawing.Size(58, 28);
            this.tabProducto.Location = new System.Drawing.Point(0, 0);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(893, 474);
            this.tabProducto.TabIndex = 1;
            // 
            // tabPermisos
            // 
            this.tabPermisos.Controls.Add(this.label3);
            this.tabPermisos.Controls.Add(this.label2);
            this.tabPermisos.Controls.Add(this.dgOtorgados);
            this.tabPermisos.Controls.Add(this.btnRevocar);
            this.tabPermisos.Controls.Add(this.btnOtorgar);
            this.tabPermisos.Controls.Add(this.dgDisponibles);
            this.tabPermisos.Controls.Add(this.cboPerfil);
            this.tabPermisos.Controls.Add(this.label1);
            this.tabPermisos.Location = new System.Drawing.Point(4, 32);
            this.tabPermisos.Name = "tabPermisos";
            this.tabPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermisos.Size = new System.Drawing.Size(885, 438);
            this.tabPermisos.TabIndex = 2;
            this.tabPermisos.Text = "Permisos";
            this.tabPermisos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Permisos Otorgados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Permisos Disponibles";
            // 
            // dgOtorgados
            // 
            this.dgOtorgados.AllowUserToAddRows = false;
            this.dgOtorgados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgOtorgados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOtorgados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgOtorgados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtorgados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandoOtorgado,
            this.comandoOtorgado});
            this.dgOtorgados.Location = new System.Drawing.Point(499, 84);
            this.dgOtorgados.MultiSelect = false;
            this.dgOtorgados.Name = "dgOtorgados";
            this.dgOtorgados.ReadOnly = true;
            this.dgOtorgados.RowHeadersVisible = false;
            this.dgOtorgados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOtorgados.Size = new System.Drawing.Size(360, 323);
            this.dgOtorgados.TabIndex = 14;
            // 
            // idComandoOtorgado
            // 
            this.idComandoOtorgado.DataPropertyName = "idComando";
            this.idComandoOtorgado.HeaderText = "ID";
            this.idComandoOtorgado.Name = "idComandoOtorgado";
            this.idComandoOtorgado.ReadOnly = true;
            this.idComandoOtorgado.Width = 50;
            // 
            // comandoOtorgado
            // 
            this.comandoOtorgado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comandoOtorgado.DataPropertyName = "comando";
            this.comandoOtorgado.HeaderText = "Comando";
            this.comandoOtorgado.Name = "comandoOtorgado";
            this.comandoOtorgado.ReadOnly = true;
            // 
            // btnRevocar
            // 
            this.btnRevocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevocar.Location = new System.Drawing.Point(406, 183);
            this.btnRevocar.Name = "btnRevocar";
            this.btnRevocar.Size = new System.Drawing.Size(76, 30);
            this.btnRevocar.TabIndex = 13;
            this.btnRevocar.Text = "<";
            this.btnRevocar.UseVisualStyleBackColor = true;
            this.btnRevocar.Click += new System.EventHandler(this.btnRevocar_Click);
            // 
            // btnOtorgar
            // 
            this.btnOtorgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtorgar.Location = new System.Drawing.Point(406, 136);
            this.btnOtorgar.Name = "btnOtorgar";
            this.btnOtorgar.Size = new System.Drawing.Size(76, 30);
            this.btnOtorgar.TabIndex = 12;
            this.btnOtorgar.Text = ">";
            this.btnOtorgar.UseVisualStyleBackColor = true;
            this.btnOtorgar.Click += new System.EventHandler(this.btnOtorgar_Click);
            // 
            // dgDisponibles
            // 
            this.dgDisponibles.AllowUserToAddRows = false;
            this.dgDisponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgDisponibles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDisponibles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandoDisponible,
            this.comandoDisponible});
            this.dgDisponibles.Location = new System.Drawing.Point(28, 84);
            this.dgDisponibles.MultiSelect = false;
            this.dgDisponibles.Name = "dgDisponibles";
            this.dgDisponibles.ReadOnly = true;
            this.dgDisponibles.RowHeadersVisible = false;
            this.dgDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDisponibles.Size = new System.Drawing.Size(360, 323);
            this.dgDisponibles.TabIndex = 11;
            // 
            // idComandoDisponible
            // 
            this.idComandoDisponible.DataPropertyName = "idComando";
            this.idComandoDisponible.HeaderText = "ID";
            this.idComandoDisponible.Name = "idComandoDisponible";
            this.idComandoDisponible.ReadOnly = true;
            this.idComandoDisponible.Width = 50;
            // 
            // comandoDisponible
            // 
            this.comandoDisponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comandoDisponible.DataPropertyName = "comando";
            this.comandoDisponible.HeaderText = "Comando";
            this.comandoDisponible.Name = "comandoDisponible";
            this.comandoDisponible.ReadOnly = true;
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(28, 33);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(295, 25);
            this.cboPerfil.TabIndex = 10;
            this.cboPerfil.SelectedValueChanged += new System.EventHandler(this.cboPerfil_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rol Seleccionado";
            // 
            // tabPerfilesComandos
            // 
            this.tabPerfilesComandos.Controls.Add(this.groupBoxComando);
            this.tabPerfilesComandos.Controls.Add(this.groupBoxPerfil);
            this.tabPerfilesComandos.Location = new System.Drawing.Point(4, 32);
            this.tabPerfilesComandos.Name = "tabPerfilesComandos";
            this.tabPerfilesComandos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerfilesComandos.Size = new System.Drawing.Size(885, 438);
            this.tabPerfilesComandos.TabIndex = 1;
            this.tabPerfilesComandos.Text = "Perfiles & Comandos";
            this.tabPerfilesComandos.UseVisualStyleBackColor = true;
            // 
            // groupBoxComando
            // 
            this.groupBoxComando.Controls.Add(this.dgComando);
            this.groupBoxComando.Controls.Add(this.btnGroupComando);
            this.groupBoxComando.Controls.Add(this.label7);
            this.groupBoxComando.Controls.Add(this.label8);
            this.groupBoxComando.Controls.Add(this.txtIdComando);
            this.groupBoxComando.Controls.Add(this.txtComando);
            this.groupBoxComando.Location = new System.Drawing.Point(455, 5);
            this.groupBoxComando.Name = "groupBoxComando";
            this.groupBoxComando.Size = new System.Drawing.Size(413, 427);
            this.groupBoxComando.TabIndex = 0;
            this.groupBoxComando.TabStop = false;
            this.groupBoxComando.Text = "Comandos";
            // 
            // dgComando
            // 
            this.dgComando.AllowUserToDeleteRows = false;
            this.dgComando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComando,
            this.comando});
            this.dgComando.Location = new System.Drawing.Point(26, 80);
            this.dgComando.Name = "dgComando";
            this.dgComando.RowHeadersVisible = false;
            this.dgComando.Size = new System.Drawing.Size(364, 291);
            this.dgComando.TabIndex = 20;
            this.dgComando.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgComando_EditingControlShowing);
            this.dgComando.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComando_RowLeave);
            // 
            // idComando
            // 
            this.idComando.DataPropertyName = "idComando";
            this.idComando.HeaderText = "Id";
            this.idComando.Name = "idComando";
            this.idComando.Width = 65;
            // 
            // comando
            // 
            this.comando.DataPropertyName = "comando";
            this.comando.HeaderText = "Comando";
            this.comando.Name = "comando";
            this.comando.Width = 275;
            // 
            // btnGroupComando
            // 
            this.btnGroupComando.AutoSize = false;
            this.btnGroupComando.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupComando.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btnGroupComando.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnComandoNewSave,
            this.toolStripSeparator5,
            this.btnComandoEditCancel,
            this.toolStripSeparator6,
            this.btnComandoDelete,
            this.toolStripLabel2,
            this.txtComandoFiltro});
            this.btnGroupComando.Location = new System.Drawing.Point(26, 374);
            this.btnGroupComando.Name = "btnGroupComando";
            this.btnGroupComando.Size = new System.Drawing.Size(364, 34);
            this.btnGroupComando.TabIndex = 19;
            this.btnGroupComando.Text = "toolStrip1";
            // 
            // btnComandoNewSave
            // 
            this.btnComandoNewSave.AutoSize = false;
            this.btnComandoNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnComandoNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComandoNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnComandoNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComandoNewSave.Name = "btnComandoNewSave";
            this.btnComandoNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnComandoNewSave.Tag = "1";
            this.btnComandoNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComandoNewSave.Click += new System.EventHandler(this.btnComandoNewSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // btnComandoEditCancel
            // 
            this.btnComandoEditCancel.AutoSize = false;
            this.btnComandoEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnComandoEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnComandoEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComandoEditCancel.Name = "btnComandoEditCancel";
            this.btnComandoEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnComandoEditCancel.Tag = "1";
            this.btnComandoEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComandoEditCancel.Click += new System.EventHandler(this.btnComandoEditCancel_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // btnComandoDelete
            // 
            this.btnComandoDelete.AutoSize = false;
            this.btnComandoDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnComandoDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnComandoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComandoDelete.Name = "btnComandoDelete";
            this.btnComandoDelete.Size = new System.Drawing.Size(36, 58);
            this.btnComandoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComandoDelete.Click += new System.EventHandler(this.btnComandoDelete_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 31);
            this.toolStripLabel2.Text = "Buscar";
            // 
            // txtComandoFiltro
            // 
            this.txtComandoFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComandoFiltro.Name = "txtComandoFiltro";
            this.txtComandoFiltro.Size = new System.Drawing.Size(175, 34);
            this.txtComandoFiltro.TextChanged += new System.EventHandler(this.txtComandoFiltro_TextChanged);
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
            // txtIdComando
            // 
            this.txtIdComando.Location = new System.Drawing.Point(90, 28);
            this.txtIdComando.Name = "txtIdComando";
            this.txtIdComando.ReadOnly = true;
            this.txtIdComando.Size = new System.Drawing.Size(60, 20);
            this.txtIdComando.TabIndex = 6;
            // 
            // txtComando
            // 
            this.txtComando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComando.Location = new System.Drawing.Point(90, 51);
            this.txtComando.Name = "txtComando";
            this.txtComando.ReadOnly = true;
            this.txtComando.Size = new System.Drawing.Size(300, 20);
            this.txtComando.TabIndex = 7;
            this.txtComando.TextChanged += new System.EventHandler(this.txtComando_TextChanged);
            // 
            // groupBoxPerfil
            // 
            this.groupBoxPerfil.Controls.Add(this.dgPerfil);
            this.groupBoxPerfil.Controls.Add(this.btnGroupPerfil);
            this.groupBoxPerfil.Controls.Add(this.label6);
            this.groupBoxPerfil.Controls.Add(this.label5);
            this.groupBoxPerfil.Controls.Add(this.txtIdPerfil);
            this.groupBoxPerfil.Controls.Add(this.txtPerfil);
            this.groupBoxPerfil.Location = new System.Drawing.Point(16, 5);
            this.groupBoxPerfil.Name = "groupBoxPerfil";
            this.groupBoxPerfil.Size = new System.Drawing.Size(413, 427);
            this.groupBoxPerfil.TabIndex = 0;
            this.groupBoxPerfil.TabStop = false;
            this.groupBoxPerfil.Text = "Perfiles del sistema";
            // 
            // dgPerfil
            // 
            this.dgPerfil.AllowUserToDeleteRows = false;
            this.dgPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRol,
            this.rol});
            this.dgPerfil.Location = new System.Drawing.Point(18, 80);
            this.dgPerfil.Name = "dgPerfil";
            this.dgPerfil.RowHeadersVisible = false;
            this.dgPerfil.Size = new System.Drawing.Size(373, 291);
            this.dgPerfil.TabIndex = 19;
            this.dgPerfil.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgPerfil_EditingControlShowing);
            this.dgPerfil.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPerfil_RowLeave);
            // 
            // idRol
            // 
            this.idRol.DataPropertyName = "idRol";
            this.idRol.HeaderText = "Id";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Width = 70;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "Perfil";
            this.rol.Name = "rol";
            this.rol.Width = 275;
            // 
            // btnGroupPerfil
            // 
            this.btnGroupPerfil.AutoSize = false;
            this.btnGroupPerfil.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupPerfil.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btnGroupPerfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfilNewSave,
            this.toolStripSeparator1,
            this.btnPerfilEditCancel,
            this.toolStripSeparator2,
            this.btnPerfilDelete,
            this.toolStripLabel1,
            this.txtPerfilFiltro});
            this.btnGroupPerfil.Location = new System.Drawing.Point(18, 374);
            this.btnGroupPerfil.Name = "btnGroupPerfil";
            this.btnGroupPerfil.Size = new System.Drawing.Size(373, 34);
            this.btnGroupPerfil.TabIndex = 18;
            this.btnGroupPerfil.Text = "toolStrip1";
            // 
            // btnPerfilNewSave
            // 
            this.btnPerfilNewSave.AutoSize = false;
            this.btnPerfilNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnPerfilNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPerfilNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerfilNewSave.Name = "btnPerfilNewSave";
            this.btnPerfilNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnPerfilNewSave.Tag = "1";
            this.btnPerfilNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfilNewSave.Click += new System.EventHandler(this.btnPerfilNewSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPerfilEditCancel
            // 
            this.btnPerfilEditCancel.AutoSize = false;
            this.btnPerfilEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnPerfilEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPerfilEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerfilEditCancel.Name = "btnPerfilEditCancel";
            this.btnPerfilEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnPerfilEditCancel.Tag = "1";
            this.btnPerfilEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfilEditCancel.Click += new System.EventHandler(this.btnPerfilEditCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnPerfilDelete
            // 
            this.btnPerfilDelete.AutoSize = false;
            this.btnPerfilDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnPerfilDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPerfilDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPerfilDelete.Name = "btnPerfilDelete";
            this.btnPerfilDelete.Size = new System.Drawing.Size(36, 58);
            this.btnPerfilDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfilDelete.Click += new System.EventHandler(this.btnPerfilDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 31);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // txtPerfilFiltro
            // 
            this.txtPerfilFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerfilFiltro.Name = "txtPerfilFiltro";
            this.txtPerfilFiltro.Size = new System.Drawing.Size(175, 34);
            this.txtPerfilFiltro.TextChanged += new System.EventHandler(this.txtPerfilFiltro_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Perfil";
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
            // txtIdPerfil
            // 
            this.txtIdPerfil.Location = new System.Drawing.Point(71, 27);
            this.txtIdPerfil.Name = "txtIdPerfil";
            this.txtIdPerfil.ReadOnly = true;
            this.txtIdPerfil.Size = new System.Drawing.Size(60, 20);
            this.txtIdPerfil.TabIndex = 2;
            // 
            // txtPerfil
            // 
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPerfil.Location = new System.Drawing.Point(71, 51);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.ReadOnly = true;
            this.txtPerfil.Size = new System.Drawing.Size(319, 20);
            this.txtPerfil.TabIndex = 3;
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(897, 465);
            this.Controls.Add(this.tabProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermisos";
            this.Text = "Gestión de permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.tabProducto.ResumeLayout(false);
            this.tabPermisos.ResumeLayout(false);
            this.tabPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtorgados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisponibles)).EndInit();
            this.tabPerfilesComandos.ResumeLayout(false);
            this.groupBoxComando.ResumeLayout(false);
            this.groupBoxComando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgComando)).EndInit();
            this.btnGroupComando.ResumeLayout(false);
            this.btnGroupComando.PerformLayout();
            this.groupBoxPerfil.ResumeLayout(false);
            this.groupBoxPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerfil)).EndInit();
            this.btnGroupPerfil.ResumeLayout(false);
            this.btnGroupPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabPerfilesComandos;
        private System.Windows.Forms.GroupBox groupBoxComando;
        private System.Windows.Forms.DataGridView dgComando;
        private System.Windows.Forms.ToolStrip btnGroupComando;
        private System.Windows.Forms.ToolStripButton btnComandoNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnComandoEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnComandoDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdComando;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.GroupBox groupBoxPerfil;
        private System.Windows.Forms.DataGridView dgPerfil;
        private System.Windows.Forms.ToolStrip btnGroupPerfil;
        private System.Windows.Forms.ToolStripButton btnPerfilNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPerfilEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPerfilDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdPerfil;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.TabPage tabPermisos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtComandoFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPerfilFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComando;
        private System.Windows.Forms.DataGridViewTextBoxColumn comando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOtorgados;
        private System.Windows.Forms.Button btnRevocar;
        private System.Windows.Forms.Button btnOtorgar;
        private System.Windows.Forms.DataGridView dgDisponibles;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandoOtorgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn comandoOtorgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comandoDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}