namespace KMonitor.GUI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnCashFlow = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnKardex = new System.Windows.Forms.Button();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(134, 82);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(125, 73);
            this.btnConfig.TabIndex = 23;
            this.btnConfig.Tag = "95";
            this.btnConfig.Text = "Configuraciones";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCashFlow
            // 
            this.btnCashFlow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCashFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCashFlow.Image = ((System.Drawing.Image)(resources.GetObject("btnCashFlow.Image")));
            this.btnCashFlow.Location = new System.Drawing.Point(265, 3);
            this.btnCashFlow.Name = "btnCashFlow";
            this.btnCashFlow.Size = new System.Drawing.Size(125, 73);
            this.btnCashFlow.TabIndex = 22;
            this.btnCashFlow.Tag = "93";
            this.btnCashFlow.Text = "Flujo de efectivo";
            this.btnCashFlow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashFlow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCashFlow.UseVisualStyleBackColor = false;
            this.btnCashFlow.Click += new System.EventHandler(this.btnCashFlow_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMonitor.BackgroundImage")));
            this.btnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMonitor.Location = new System.Drawing.Point(3, 3);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(125, 73);
            this.btnMonitor.TabIndex = 24;
            this.btnMonitor.Tag = "91";
            this.btnMonitor.Text = "Monitor de cocina";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(265, 82);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 73);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKardex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKardex.Image = ((System.Drawing.Image)(resources.GetObject("btnKardex.Image")));
            this.btnKardex.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKardex.Location = new System.Drawing.Point(134, 3);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(125, 73);
            this.btnKardex.TabIndex = 26;
            this.btnKardex.Tag = "92";
            this.btnKardex.Text = "Kardex";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKardex.UseVisualStyleBackColor = false;
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // btnEgresos
            // 
            this.btnEgresos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgresos.Image = ((System.Drawing.Image)(resources.GetObject("btnEgresos.Image")));
            this.btnEgresos.Location = new System.Drawing.Point(3, 82);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(125, 73);
            this.btnEgresos.TabIndex = 27;
            this.btnEgresos.Tag = "94";
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEgresos.UseVisualStyleBackColor = false;
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.btnMonitor);
            this.flowLayoutPanelMenu.Controls.Add(this.btnKardex);
            this.flowLayoutPanelMenu.Controls.Add(this.btnCashFlow);
            this.flowLayoutPanelMenu.Controls.Add(this.btnEgresos);
            this.flowLayoutPanelMenu.Controls.Add(this.btnConfig);
            this.flowLayoutPanelMenu.Controls.Add(this.btnSalir);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(404, 164);
            this.flowLayoutPanelMenu.TabIndex = 28;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(404, 164);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnCashFlow;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnKardex;
        private System.Windows.Forms.Button btnEgresos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
    }
}