namespace DBM.GUI
{
    partial class frmCNX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCNX));
            this.btnObtieneCNX = new System.Windows.Forms.Button();
            this.btnProtegeCNX = new System.Windows.Forms.Button();
            this.btnCambiaCNX = new System.Windows.Forms.Button();
            this.txtCadenaConexion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBDServer = new System.Windows.Forms.PictureBox();
            this.lblMessageForm = new System.Windows.Forms.Label();
            this.btnDesProtegeCNX = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBDServer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtieneCNX
            // 
            this.btnObtieneCNX.Location = new System.Drawing.Point(44, 156);
            this.btnObtieneCNX.Name = "btnObtieneCNX";
            this.btnObtieneCNX.Size = new System.Drawing.Size(123, 43);
            this.btnObtieneCNX.TabIndex = 0;
            this.btnObtieneCNX.Text = "Ver cadena de conexión";
            this.btnObtieneCNX.UseVisualStyleBackColor = true;
            this.btnObtieneCNX.Click += new System.EventHandler(this.btnObtieneCNX_Click);
            // 
            // btnProtegeCNX
            // 
            this.btnProtegeCNX.Location = new System.Drawing.Point(366, 156);
            this.btnProtegeCNX.Name = "btnProtegeCNX";
            this.btnProtegeCNX.Size = new System.Drawing.Size(86, 43);
            this.btnProtegeCNX.TabIndex = 1;
            this.btnProtegeCNX.Text = "Proteger conexión";
            this.btnProtegeCNX.UseVisualStyleBackColor = true;
            this.btnProtegeCNX.Click += new System.EventHandler(this.btnProtegeCNX_Click);
            // 
            // btnCambiaCNX
            // 
            this.btnCambiaCNX.Location = new System.Drawing.Point(222, 156);
            this.btnCambiaCNX.Name = "btnCambiaCNX";
            this.btnCambiaCNX.Size = new System.Drawing.Size(120, 43);
            this.btnCambiaCNX.TabIndex = 2;
            this.btnCambiaCNX.Text = "&Guardar";
            this.btnCambiaCNX.UseVisualStyleBackColor = true;
            this.btnCambiaCNX.Click += new System.EventHandler(this.btnCambiaCNX_Click);
            // 
            // txtCadenaConexion
            // 
            this.txtCadenaConexion.Location = new System.Drawing.Point(44, 123);
            this.txtCadenaConexion.Name = "txtCadenaConexion";
            this.txtCadenaConexion.Size = new System.Drawing.Size(498, 20);
            this.txtCadenaConexion.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBDServer);
            this.groupBox2.Controls.Add(this.lblMessageForm);
            this.groupBox2.Location = new System.Drawing.Point(44, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // picBDServer
            // 
            this.picBDServer.Image = global::DBM.Properties.Resources.iconDB;
            this.picBDServer.Location = new System.Drawing.Point(6, 19);
            this.picBDServer.Name = "picBDServer";
            this.picBDServer.Size = new System.Drawing.Size(72, 72);
            this.picBDServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBDServer.TabIndex = 1;
            this.picBDServer.TabStop = false;
            // 
            // lblMessageForm
            // 
            this.lblMessageForm.Location = new System.Drawing.Point(89, 28);
            this.lblMessageForm.Name = "lblMessageForm";
            this.lblMessageForm.Size = new System.Drawing.Size(403, 52);
            this.lblMessageForm.TabIndex = 0;
            this.lblMessageForm.Text = "¡Adevertencia! Cambiar los datos de conexión de MySQL podría hacer que la aplicac" +
    "ión deje de trabajar adecuadamente. Use esta herramienta adecuadamente";
            this.lblMessageForm.UseCompatibleTextRendering = true;
            // 
            // btnDesProtegeCNX
            // 
            this.btnDesProtegeCNX.Location = new System.Drawing.Point(457, 156);
            this.btnDesProtegeCNX.Name = "btnDesProtegeCNX";
            this.btnDesProtegeCNX.Size = new System.Drawing.Size(85, 43);
            this.btnDesProtegeCNX.TabIndex = 9;
            this.btnDesProtegeCNX.Text = "Desproteger conexión";
            this.btnDesProtegeCNX.UseVisualStyleBackColor = true;
            this.btnDesProtegeCNX.Click += new System.EventHandler(this.btnDesProtegeCNX_Click);
            // 
            // frmCNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 227);
            this.Controls.Add(this.btnDesProtegeCNX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCadenaConexion);
            this.Controls.Add(this.btnCambiaCNX);
            this.Controls.Add(this.btnProtegeCNX);
            this.Controls.Add(this.btnObtieneCNX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCNX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.frmCNX_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBDServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtieneCNX;
        private System.Windows.Forms.Button btnProtegeCNX;
        private System.Windows.Forms.Button btnCambiaCNX;
        private System.Windows.Forms.TextBox txtCadenaConexion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBDServer;
        private System.Windows.Forms.Label lblMessageForm;
        private System.Windows.Forms.Button btnDesProtegeCNX;
    }
}