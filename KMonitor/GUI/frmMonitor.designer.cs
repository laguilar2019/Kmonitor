namespace KMonitor.GUI
{
    partial class frmMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.flowPanelPendiente = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowPanelFinalizado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelProceso = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSendToProcesar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendToFinalizar = new System.Windows.Forms.Button();
            this.btnSendToPendientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfiguraciones = new System.Windows.Forms.Button();
            this.btnShowHideFrmDetalle = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.timerCambios = new System.Windows.Forms.Timer(this.components);
            this.timerVisibilidadporCategorias = new System.Windows.Forms.Timer(this.components);
            this.contextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuSettings,
            this.ContextMenuExit});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(162, 48);
            // 
            // ContextMenuSettings
            // 
            this.ContextMenuSettings.Name = "ContextMenuSettings";
            this.ContextMenuSettings.Size = new System.Drawing.Size(161, 22);
            this.ContextMenuSettings.Text = "Configuraciones";
            this.ContextMenuSettings.Click += new System.EventHandler(this.MenuContextualKMonitor_Click);
            // 
            // ContextMenuExit
            // 
            this.ContextMenuExit.Name = "ContextMenuExit";
            this.ContextMenuExit.Size = new System.Drawing.Size(161, 22);
            this.ContextMenuExit.Text = "Salir";
            this.ContextMenuExit.Click += new System.EventHandler(this.ContextMenuExit_Click);
            // 
            // flowPanelPendiente
            // 
            this.flowPanelPendiente.AutoScroll = true;
            this.flowPanelPendiente.BackColor = System.Drawing.Color.Khaki;
            this.flowPanelPendiente.ContextMenuStrip = this.contextMenu;
            this.flowPanelPendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelPendiente.Location = new System.Drawing.Point(3, 3);
            this.flowPanelPendiente.Name = "flowPanelPendiente";
            this.flowPanelPendiente.Size = new System.Drawing.Size(297, 432);
            this.flowPanelPendiente.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.flowPanelFinalizado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowPanelProceso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowPanelPendiente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSendToProcesar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 516);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowPanelFinalizado
            // 
            this.flowPanelFinalizado.AutoScroll = true;
            this.flowPanelFinalizado.BackColor = System.Drawing.Color.IndianRed;
            this.flowPanelFinalizado.ContextMenuStrip = this.contextMenu;
            this.flowPanelFinalizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelFinalizado.Location = new System.Drawing.Point(609, 3);
            this.flowPanelFinalizado.Name = "flowPanelFinalizado";
            this.flowPanelFinalizado.Size = new System.Drawing.Size(298, 432);
            this.flowPanelFinalizado.TabIndex = 3;
            // 
            // flowPanelProceso
            // 
            this.flowPanelProceso.AutoScroll = true;
            this.flowPanelProceso.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowPanelProceso.ContextMenuStrip = this.contextMenu;
            this.flowPanelProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelProceso.Location = new System.Drawing.Point(306, 3);
            this.flowPanelProceso.Name = "flowPanelProceso";
            this.flowPanelProceso.Size = new System.Drawing.Size(297, 432);
            this.flowPanelProceso.TabIndex = 2;
            // 
            // btnSendToProcesar
            // 
            this.btnSendToProcesar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendToProcesar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendToProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnSendToProcesar.Image")));
            this.btnSendToProcesar.Location = new System.Drawing.Point(3, 441);
            this.btnSendToProcesar.Name = "btnSendToProcesar";
            this.btnSendToProcesar.Size = new System.Drawing.Size(297, 72);
            this.btnSendToProcesar.TabIndex = 0;
            this.btnSendToProcesar.UseVisualStyleBackColor = false;
            this.btnSendToProcesar.Click += new System.EventHandler(this.btnSendToProcesar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendToFinalizar);
            this.panel1.Controls.Add(this.btnSendToPendientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(306, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 72);
            this.panel1.TabIndex = 5;
            // 
            // btnSendToFinalizar
            // 
            this.btnSendToFinalizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendToFinalizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendToFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnSendToFinalizar.Image")));
            this.btnSendToFinalizar.Location = new System.Drawing.Point(149, 0);
            this.btnSendToFinalizar.Name = "btnSendToFinalizar";
            this.btnSendToFinalizar.Size = new System.Drawing.Size(148, 72);
            this.btnSendToFinalizar.TabIndex = 1;
            this.btnSendToFinalizar.UseVisualStyleBackColor = false;
            this.btnSendToFinalizar.Click += new System.EventHandler(this.btnSendToFinalizar_Click);
            // 
            // btnSendToPendientes
            // 
            this.btnSendToPendientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendToPendientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSendToPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnSendToPendientes.Image")));
            this.btnSendToPendientes.Location = new System.Drawing.Point(0, 0);
            this.btnSendToPendientes.Name = "btnSendToPendientes";
            this.btnSendToPendientes.Size = new System.Drawing.Size(148, 72);
            this.btnSendToPendientes.TabIndex = 0;
            this.btnSendToPendientes.UseVisualStyleBackColor = false;
            this.btnSendToPendientes.Click += new System.EventHandler(this.btnSendToPendientes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnConfiguraciones);
            this.panel2.Controls.Add(this.btnShowHideFrmDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(609, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 72);
            this.panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(218, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 72);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguraciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguraciones.Image")));
            this.btnConfiguraciones.Location = new System.Drawing.Point(112, 0);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(104, 72);
            this.btnConfiguraciones.TabIndex = 5;
            this.btnConfiguraciones.UseVisualStyleBackColor = false;
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // btnShowHideFrmDetalle
            // 
            this.btnShowHideFrmDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowHideFrmDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowHideFrmDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHideFrmDetalle.Image")));
            this.btnShowHideFrmDetalle.Location = new System.Drawing.Point(3, 0);
            this.btnShowHideFrmDetalle.Name = "btnShowHideFrmDetalle";
            this.btnShowHideFrmDetalle.Size = new System.Drawing.Size(106, 72);
            this.btnShowHideFrmDetalle.TabIndex = 4;
            this.btnShowHideFrmDetalle.Tag = "1";
            this.btnShowHideFrmDetalle.UseVisualStyleBackColor = false;
            this.btnShowHideFrmDetalle.Click += new System.EventHandler(this.btnShowHideFrmDetalle_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 5000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // timerCambios
            // 
            this.timerCambios.Interval = 3000;
            this.timerCambios.Tick += new System.EventHandler(this.timerCambios_Tick);
            // 
            // timerVisibilidadporCategorias
            // 
            this.timerVisibilidadporCategorias.Interval = 3000;
            this.timerVisibilidadporCategorias.Tick += new System.EventHandler(this.timerVisibilidadporCategorias_Tick);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor de cocina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonitor2_Load);
            this.contextMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowPanelPendiente;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelFinalizado;
        private System.Windows.Forms.FlowLayoutPanel flowPanelProceso;
        private System.Windows.Forms.Button btnSendToProcesar;
        private System.Windows.Forms.Button btnShowHideFrmDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendToFinalizar;
        private System.Windows.Forms.Button btnSendToPendientes;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfiguraciones;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Timer timerCambios;
        private System.Windows.Forms.Timer timerVisibilidadporCategorias;
    }
}