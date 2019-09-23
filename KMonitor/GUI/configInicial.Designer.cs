namespace KMonitor.GUI
{
    partial class configInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configInicial));
            this.btnReparaListo = new System.Windows.Forms.Button();
            this.btnCnx = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.edtLogFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrivilegios = new System.Windows.Forms.Button();
            this.btnCambiosEnPedidoDetalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReparaListo
            // 
            this.btnReparaListo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReparaListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReparaListo.Image = ((System.Drawing.Image)(resources.GetObject("btnReparaListo.Image")));
            this.btnReparaListo.Location = new System.Drawing.Point(144, 60);
            this.btnReparaListo.Name = "btnReparaListo";
            this.btnReparaListo.Size = new System.Drawing.Size(190, 61);
            this.btnReparaListo.TabIndex = 9;
            this.btnReparaListo.Text = "Ajustar campo LISTO en Pedido";
            this.btnReparaListo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReparaListo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReparaListo.UseVisualStyleBackColor = false;
            this.btnReparaListo.Click += new System.EventHandler(this.btnReoaraListo_Click);
            // 
            // btnCnx
            // 
            this.btnCnx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCnx.Image = ((System.Drawing.Image)(resources.GetObject("btnCnx.Image")));
            this.btnCnx.Location = new System.Drawing.Point(19, 60);
            this.btnCnx.Name = "btnCnx";
            this.btnCnx.Size = new System.Drawing.Size(119, 61);
            this.btnCnx.TabIndex = 8;
            this.btnCnx.Text = "Conexión";
            this.btnCnx.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCnx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCnx.UseVisualStyleBackColor = false;
            this.btnCnx.Click += new System.EventHandler(this.btnCnx_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Image = global::KMonitor.Properties.Resources.close;
            this.btnSalir.Location = new System.Drawing.Point(860, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateTable.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateTable.Image")));
            this.btnCreateTable.Location = new System.Drawing.Point(340, 60);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(184, 61);
            this.btnCreateTable.TabIndex = 10;
            this.btnCreateTable.Text = "Crear tabla para tipos de egresos";
            this.btnCreateTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateTable.UseVisualStyleBackColor = false;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // edtLogFile
            // 
            this.edtLogFile.FormattingEnabled = true;
            this.edtLogFile.Location = new System.Drawing.Point(19, 125);
            this.edtLogFile.Name = "edtLogFile";
            this.edtLogFile.ScrollAlwaysVisible = true;
            this.edtLogFile.Size = new System.Drawing.Size(888, 186);
            this.edtLogFile.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Antes de realizar estos cambios consulte con el administrador del sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrivilegios
            // 
            this.btnPrivilegios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrivilegios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrivilegios.Image = ((System.Drawing.Image)(resources.GetObject("btnPrivilegios.Image")));
            this.btnPrivilegios.Location = new System.Drawing.Point(763, 60);
            this.btnPrivilegios.Name = "btnPrivilegios";
            this.btnPrivilegios.Size = new System.Drawing.Size(144, 61);
            this.btnPrivilegios.TabIndex = 13;
            this.btnPrivilegios.Text = "Privilegios del sistema";
            this.btnPrivilegios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrivilegios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrivilegios.UseVisualStyleBackColor = false;
            this.btnPrivilegios.Click += new System.EventHandler(this.btnPrivilegios_Click);
            // 
            // btnCambiosEnPedidoDetalle
            // 
            this.btnCambiosEnPedidoDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCambiosEnPedidoDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCambiosEnPedidoDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiosEnPedidoDetalle.Image")));
            this.btnCambiosEnPedidoDetalle.Location = new System.Drawing.Point(530, 60);
            this.btnCambiosEnPedidoDetalle.Name = "btnCambiosEnPedidoDetalle";
            this.btnCambiosEnPedidoDetalle.Size = new System.Drawing.Size(184, 61);
            this.btnCambiosEnPedidoDetalle.TabIndex = 14;
            this.btnCambiosEnPedidoDetalle.Text = "Config. Pedido_detalles";
            this.btnCambiosEnPedidoDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiosEnPedidoDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiosEnPedidoDetalle.UseVisualStyleBackColor = false;
            this.btnCambiosEnPedidoDetalle.Click += new System.EventHandler(this.btnCambiosEnPedidoDetalle_Click);
            // 
            // configInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(929, 346);
            this.ControlBox = false;
            this.Controls.Add(this.btnCambiosEnPedidoDetalle);
            this.Controls.Add(this.btnPrivilegios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtLogFile);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnReparaListo);
            this.Controls.Add(this.btnCnx);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsInitial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReparaListo;
        private System.Windows.Forms.Button btnCnx;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.ListBox edtLogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrivilegios;
        private System.Windows.Forms.Button btnCambiosEnPedidoDetalle;
    }
}