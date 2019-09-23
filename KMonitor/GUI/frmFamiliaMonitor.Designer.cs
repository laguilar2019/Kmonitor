namespace KMonitor.GUI
{
    partial class frmFamiliaMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFamiliaMonitor));
            this.dgFamilia = new System.Windows.Forms.DataGridView();
            this.idFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enMonitor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnXmlSave = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFamilia
            // 
            this.dgFamilia.AllowUserToAddRows = false;
            this.dgFamilia.AllowUserToDeleteRows = false;
            this.dgFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamilia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFamilia,
            this.familia,
            this.enMonitor});
            this.dgFamilia.Location = new System.Drawing.Point(14, 14);
            this.dgFamilia.Name = "dgFamilia";
            this.dgFamilia.Size = new System.Drawing.Size(417, 390);
            this.dgFamilia.TabIndex = 0;
            // 
            // idFamilia
            // 
            this.idFamilia.DataPropertyName = "idFamilia";
            this.idFamilia.HeaderText = "ID";
            this.idFamilia.Name = "idFamilia";
            this.idFamilia.Width = 50;
            // 
            // familia
            // 
            this.familia.DataPropertyName = "familia";
            this.familia.HeaderText = "Familia";
            this.familia.Name = "familia";
            this.familia.ReadOnly = true;
            this.familia.Width = 250;
            // 
            // enMonitor
            // 
            this.enMonitor.DataPropertyName = "enMonitor";
            this.enMonitor.FalseValue = "0";
            this.enMonitor.HeaderText = "Mostrar ";
            this.enMonitor.Name = "enMonitor";
            this.enMonitor.TrueValue = "1";
            this.enMonitor.Width = 80;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Image = global::KMonitor.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(228, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 20);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnXmlSave
            // 
            this.btnXmlSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXmlSave.Image = global::KMonitor.Properties.Resources.save;
            this.btnXmlSave.Location = new System.Drawing.Point(210, 409);
            this.btnXmlSave.Name = "btnXmlSave";
            this.btnXmlSave.Size = new System.Drawing.Size(221, 57);
            this.btnXmlSave.TabIndex = 3;
            this.btnXmlSave.Text = "XML";
            this.btnXmlSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXmlSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXmlSave.UseVisualStyleBackColor = false;
            this.btnXmlSave.Click += new System.EventHandler(this.btnXmlSave_Click);
            // 
            // btnCambios
            // 
            this.btnCambios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCambios.Image = ((System.Drawing.Image)(resources.GetObject("btnCambios.Image")));
            this.btnCambios.Location = new System.Drawing.Point(14, 410);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(190, 57);
            this.btnCambios.TabIndex = 4;
            this.btnCambios.Text = "Buscar cambios en BD";
            this.btnCambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambios.UseVisualStyleBackColor = false;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // frmFamiliaMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(443, 478);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnXmlSave);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgFamilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFamiliaMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFamiliaMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFamilia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enMonitor;
        private System.Windows.Forms.Button btnXmlSave;
        private System.Windows.Forms.Button btnCambios;
    }
}