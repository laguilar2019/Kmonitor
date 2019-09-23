namespace KMonitor.GUI
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlturaPanel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAltoPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnchoPedido = new System.Windows.Forms.TextBox();
            this.txtAltoSalon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnchoSalon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCnx = new System.Windows.Forms.Button();
            this.btnRespaldos = new System.Windows.Forms.Button();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlturaPanel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAltoPedido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAnchoPedido);
            this.groupBox1.Controls.Add(this.txtAltoSalon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAnchoSalon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño de botones";
            // 
            // txtAlturaPanel
            // 
            this.txtAlturaPanel.Location = new System.Drawing.Point(429, 23);
            this.txtAlturaPanel.Name = "txtAlturaPanel";
            this.txtAlturaPanel.Size = new System.Drawing.Size(76, 20);
            this.txtAlturaPanel.TabIndex = 7;
            this.txtAlturaPanel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnchoSalon_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Altura del panel";
            // 
            // txtAltoPedido
            // 
            this.txtAltoPedido.Location = new System.Drawing.Point(256, 59);
            this.txtAltoPedido.Name = "txtAltoPedido";
            this.txtAltoPedido.Size = new System.Drawing.Size(65, 20);
            this.txtAltoPedido.TabIndex = 9;
            this.txtAltoPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnchoSalon_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "alto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ancho";
            // 
            // txtAnchoPedido
            // 
            this.txtAnchoPedido.Location = new System.Drawing.Point(153, 59);
            this.txtAnchoPedido.Name = "txtAnchoPedido";
            this.txtAnchoPedido.Size = new System.Drawing.Size(65, 20);
            this.txtAnchoPedido.TabIndex = 6;
            this.txtAnchoPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnchoSalon_KeyPress);
            // 
            // txtAltoSalon
            // 
            this.txtAltoSalon.Location = new System.Drawing.Point(256, 23);
            this.txtAltoSalon.Name = "txtAltoSalon";
            this.txtAltoSalon.Size = new System.Drawing.Size(65, 20);
            this.txtAltoSalon.TabIndex = 5;
            this.txtAltoSalon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnchoSalon_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ancho";
            // 
            // txtAnchoSalon
            // 
            this.txtAnchoSalon.Location = new System.Drawing.Point(153, 23);
            this.txtAnchoSalon.Name = "txtAnchoSalon";
            this.txtAnchoSalon.Size = new System.Drawing.Size(65, 20);
            this.txtAnchoSalon.TabIndex = 2;
            this.txtAnchoSalon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnchoSalon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pedidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salones:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Image = global::KMonitor.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(194, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 54);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Image = global::KMonitor.Properties.Resources.close;
            this.btnSalir.Location = new System.Drawing.Point(414, 113);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 54);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCnx
            // 
            this.btnCnx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCnx.Image = ((System.Drawing.Image)(resources.GetObject("btnCnx.Image")));
            this.btnCnx.Location = new System.Drawing.Point(6, 113);
            this.btnCnx.Name = "btnCnx";
            this.btnCnx.Size = new System.Drawing.Size(89, 54);
            this.btnCnx.TabIndex = 3;
            this.btnCnx.Text = "Conexión";
            this.btnCnx.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCnx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCnx.UseVisualStyleBackColor = false;
            this.btnCnx.Click += new System.EventHandler(this.btnCnx_Click);
            // 
            // btnRespaldos
            // 
            this.btnRespaldos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRespaldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRespaldos.Image = ((System.Drawing.Image)(resources.GetObject("btnRespaldos.Image")));
            this.btnRespaldos.Location = new System.Drawing.Point(100, 113);
            this.btnRespaldos.Name = "btnRespaldos";
            this.btnRespaldos.Size = new System.Drawing.Size(89, 54);
            this.btnRespaldos.TabIndex = 4;
            this.btnRespaldos.Text = "Respaldos";
            this.btnRespaldos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRespaldos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRespaldos.UseVisualStyleBackColor = false;
            this.btnRespaldos.Click += new System.EventHandler(this.btnRespaldos_Click);
            // 
            // btnFamilia
            // 
            this.btnFamilia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnFamilia.Image")));
            this.btnFamilia.Location = new System.Drawing.Point(289, 113);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(123, 54);
            this.btnFamilia.TabIndex = 5;
            this.btnFamilia.Text = "Familias a mostrar";
            this.btnFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFamilia.UseVisualStyleBackColor = false;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 179);
            this.Controls.Add(this.btnFamilia);
            this.Controls.Add(this.btnRespaldos);
            this.Controls.Add(this.btnCnx);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones del sistema";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAltoPedido;
        public System.Windows.Forms.TextBox txtAnchoPedido;
        public System.Windows.Forms.TextBox txtAltoSalon;
        public System.Windows.Forms.TextBox txtAnchoSalon;
        public System.Windows.Forms.TextBox txtAlturaPanel;
        private System.Windows.Forms.Button btnCnx;
        private System.Windows.Forms.Button btnRespaldos;
        private System.Windows.Forms.Button btnFamilia;
    }
}