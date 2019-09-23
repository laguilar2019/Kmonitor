namespace KMonitor.GUI
{
    partial class frmEgresoTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEgresoTipo));
            this.groupBoxTipoEgreso = new System.Windows.Forms.GroupBox();
            this.dgEgresoTipo = new System.Windows.Forms.DataGridView();
            this.btnGroupCategoria = new System.Windows.Forms.ToolStrip();
            this.btnNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdEgresoTipo = new System.Windows.Forms.TextBox();
            this.txtEgresoTipo = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.idEgresoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTipoEgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresoTipo)).BeginInit();
            this.btnGroupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTipoEgreso
            // 
            this.groupBoxTipoEgreso.Controls.Add(this.dgEgresoTipo);
            this.groupBoxTipoEgreso.Controls.Add(this.btnGroupCategoria);
            this.groupBoxTipoEgreso.Controls.Add(this.label6);
            this.groupBoxTipoEgreso.Controls.Add(this.label5);
            this.groupBoxTipoEgreso.Controls.Add(this.txtIdEgresoTipo);
            this.groupBoxTipoEgreso.Controls.Add(this.txtEgresoTipo);
            this.groupBoxTipoEgreso.Location = new System.Drawing.Point(22, 23);
            this.groupBoxTipoEgreso.Name = "groupBoxTipoEgreso";
            this.groupBoxTipoEgreso.Size = new System.Drawing.Size(518, 329);
            this.groupBoxTipoEgreso.TabIndex = 1;
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
            this.dgEgresoTipo.Location = new System.Drawing.Point(18, 80);
            this.dgEgresoTipo.Name = "dgEgresoTipo";
            this.dgEgresoTipo.ReadOnly = true;
            this.dgEgresoTipo.RowHeadersVisible = false;
            this.dgEgresoTipo.RowTemplate.Height = 30;
            this.dgEgresoTipo.Size = new System.Drawing.Size(474, 230);
            this.dgEgresoTipo.TabIndex = 19;
            this.dgEgresoTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstado_CellContentClick);
            this.dgEgresoTipo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEstado_CellFormatting);
            // 
            // btnGroupCategoria
            // 
            this.btnGroupCategoria.AutoSize = false;
            this.btnGroupCategoria.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewSave,
            this.toolStripSeparator1,
            this.btnEditCancel,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnSearch,
            this.toolStripSeparator3});
            this.btnGroupCategoria.Location = new System.Drawing.Point(179, 12);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
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
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de egreso";
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
            // txtIdEgresoTipo
            // 
            this.txtIdEgresoTipo.Location = new System.Drawing.Point(99, 27);
            this.txtIdEgresoTipo.Name = "txtIdEgresoTipo";
            this.txtIdEgresoTipo.ReadOnly = true;
            this.txtIdEgresoTipo.Size = new System.Drawing.Size(60, 20);
            this.txtIdEgresoTipo.TabIndex = 2;
            // 
            // txtEgresoTipo
            // 
            this.txtEgresoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEgresoTipo.Location = new System.Drawing.Point(99, 51);
            this.txtEgresoTipo.Name = "txtEgresoTipo";
            this.txtEgresoTipo.ReadOnly = true;
            this.txtEgresoTipo.Size = new System.Drawing.Size(393, 20);
            this.txtEgresoTipo.TabIndex = 3;
            this.txtEgresoTipo.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
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
            // frmEgresoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 357);
            this.Controls.Add(this.groupBoxTipoEgreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEgresoTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de egresos a registrar";
            this.Load += new System.EventHandler(this.frmEstado_Load);
            this.groupBoxTipoEgreso.ResumeLayout(false);
            this.groupBoxTipoEgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEgresoTipo)).EndInit();
            this.btnGroupCategoria.ResumeLayout(false);
            this.btnGroupCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoEgreso;
        private System.Windows.Forms.DataGridView dgEgresoTipo;
        private System.Windows.Forms.ToolStrip btnGroupCategoria;
        private System.Windows.Forms.ToolStripButton btnNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEgresoTipo;
        private System.Windows.Forms.TextBox txtEgresoTipo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEgresoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresoTipo;
    }
}