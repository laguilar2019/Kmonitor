namespace KMonitor.GUI
{
    partial class frmEstado
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
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.CboColorPicker = new System.Windows.Forms.ComboBox();
            this.dgEstado = new System.Windows.Forms.DataGridView();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtIdEstado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.groupBoxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).BeginInit();
            this.btnGroupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.CboColorPicker);
            this.groupBoxCategoria.Controls.Add(this.dgEstado);
            this.groupBoxCategoria.Controls.Add(this.btnGroupCategoria);
            this.groupBoxCategoria.Controls.Add(this.label6);
            this.groupBoxCategoria.Controls.Add(this.label5);
            this.groupBoxCategoria.Controls.Add(this.txtIdEstado);
            this.groupBoxCategoria.Controls.Add(this.txtEstado);
            this.groupBoxCategoria.Location = new System.Drawing.Point(22, 23);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(518, 329);
            this.groupBoxCategoria.TabIndex = 1;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "Categoría";
            // 
            // CboColorPicker
            // 
            this.CboColorPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboColorPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboColorPicker.FormattingEnabled = true;
            this.CboColorPicker.Location = new System.Drawing.Point(304, 51);
            this.CboColorPicker.Name = "CboColorPicker";
            this.CboColorPicker.Size = new System.Drawing.Size(188, 21);
            this.CboColorPicker.TabIndex = 22;
            this.CboColorPicker.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // dgEstado
            // 
            this.dgEstado.AllowUserToAddRows = false;
            this.dgEstado.AllowUserToDeleteRows = false;
            this.dgEstado.ColumnHeadersHeight = 30;
            this.dgEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstado,
            this.estado,
            this.color});
            this.dgEstado.Location = new System.Drawing.Point(18, 80);
            this.dgEstado.Name = "dgEstado";
            this.dgEstado.ReadOnly = true;
            this.dgEstado.RowHeadersVisible = false;
            this.dgEstado.RowTemplate.Height = 30;
            this.dgEstado.Size = new System.Drawing.Size(474, 230);
            this.dgEstado.TabIndex = 19;
            this.dgEstado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstado_CellContentClick);
            this.dgEstado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEstado_CellFormatting);
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "Id";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Width = 70;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 225;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 175;
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
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
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
            // txtIdEstado
            // 
            this.txtIdEstado.Location = new System.Drawing.Point(71, 27);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.ReadOnly = true;
            this.txtIdEstado.Size = new System.Drawing.Size(60, 20);
            this.txtIdEstado.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(71, 51);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(226, 20);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(387, 4);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 2;
            this.btnPrueba.Text = "button1";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // frmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 357);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.groupBoxCategoria);
            this.Name = "frmEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de las comandas";
            this.Load += new System.EventHandler(this.frmEstado_Load);
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstado)).EndInit();
            this.btnGroupCategoria.ResumeLayout(false);
            this.btnGroupCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.DataGridView dgEstado;
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
        private System.Windows.Forms.TextBox txtIdEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox CboColorPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.Button btnPrueba;
    }
}