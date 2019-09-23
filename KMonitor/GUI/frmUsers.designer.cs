namespace KMonitor.GUI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnGroupUsuario = new System.Windows.Forms.ToolStrip();
            this.btnUsuarioNewSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsuarioEditCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsuarioDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.btnFinal = new System.Windows.Forms.Button();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.lblEnrolar = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.chkChangePassword = new System.Windows.Forms.CheckBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGroupUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.groupBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGroupUsuario
            // 
            this.btnGroupUsuario.AutoSize = false;
            this.btnGroupUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.btnGroupUsuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btnGroupUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarioNewSave,
            this.toolStripSeparator1,
            this.btnUsuarioEditCancel,
            this.toolStripSeparator2,
            this.btnUsuarioDelete,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txtFiltro});
            this.btnGroupUsuario.Location = new System.Drawing.Point(74, 385);
            this.btnGroupUsuario.Name = "btnGroupUsuario";
            this.btnGroupUsuario.Size = new System.Drawing.Size(584, 38);
            this.btnGroupUsuario.TabIndex = 0;
            this.btnGroupUsuario.Text = "toolStrip1";
            // 
            // btnUsuarioNewSave
            // 
            this.btnUsuarioNewSave.AutoSize = false;
            this.btnUsuarioNewSave.Image = global::KMonitor.Properties.Resources.new_;
            this.btnUsuarioNewSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioNewSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarioNewSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarioNewSave.Name = "btnUsuarioNewSave";
            this.btnUsuarioNewSave.Size = new System.Drawing.Size(36, 58);
            this.btnUsuarioNewSave.Tag = "1";
            this.btnUsuarioNewSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioNewSave.Click += new System.EventHandler(this.btnUsuarioNewSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnUsuarioEditCancel
            // 
            this.btnUsuarioEditCancel.AutoSize = false;
            this.btnUsuarioEditCancel.Image = global::KMonitor.Properties.Resources.edit;
            this.btnUsuarioEditCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarioEditCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarioEditCancel.Name = "btnUsuarioEditCancel";
            this.btnUsuarioEditCancel.Size = new System.Drawing.Size(36, 58);
            this.btnUsuarioEditCancel.Tag = "1";
            this.btnUsuarioEditCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioEditCancel.Click += new System.EventHandler(this.btnUsuarioEditCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnUsuarioDelete
            // 
            this.btnUsuarioDelete.AutoSize = false;
            this.btnUsuarioDelete.Image = global::KMonitor.Properties.Resources.delete;
            this.btnUsuarioDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarioDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarioDelete.Name = "btnUsuarioDelete";
            this.btnUsuarioDelete.Size = new System.Drawing.Size(36, 58);
            this.btnUsuarioDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioDelete.Click += new System.EventHandler(this.btnUsuarioDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 35);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(250, 38);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinal.Image = global::KMonitor.Properties.Resources.flechadown;
            this.btnFinal.Location = new System.Drawing.Point(13, 385);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(45, 34);
            this.btnFinal.TabIndex = 7;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.AllowUserToDeleteRows = false;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombres,
            this.apellidos,
            this.telefono,
            this.email});
            this.dgUsuario.Location = new System.Drawing.Point(14, 111);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.ReadOnly = true;
            this.dgUsuario.Size = new System.Drawing.Size(874, 267);
            this.dgUsuario.TabIndex = 6;
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.txtApellidos);
            this.groupBoxUsuario.Controls.Add(this.label1);
            this.groupBoxUsuario.Controls.Add(this.txtPassword2);
            this.groupBoxUsuario.Controls.Add(this.lblPassword2);
            this.groupBoxUsuario.Controls.Add(this.pictureBox1);
            this.groupBoxUsuario.Controls.Add(this.cboPerfil);
            this.groupBoxUsuario.Controls.Add(this.lblEnrolar);
            this.groupBoxUsuario.Controls.Add(this.txtPassword);
            this.groupBoxUsuario.Controls.Add(this.txtIdUsuario);
            this.groupBoxUsuario.Controls.Add(this.lblPassword);
            this.groupBoxUsuario.Controls.Add(this.txtTelefono);
            this.groupBoxUsuario.Controls.Add(this.lblTelefono);
            this.groupBoxUsuario.Controls.Add(this.txtEmail);
            this.groupBoxUsuario.Controls.Add(this.lblEmail);
            this.groupBoxUsuario.Controls.Add(this.txtNombres);
            this.groupBoxUsuario.Controls.Add(this.lblNombre);
            this.groupBoxUsuario.Controls.Add(this.LblUsuario);
            this.groupBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(13, 4);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(875, 106);
            this.groupBoxUsuario.TabIndex = 8;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Datos del usuario";
            this.groupBoxUsuario.Enter += new System.EventHandler(this.groupBoxUsuario_Enter);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(706, 72);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.ReadOnly = true;
            this.txtPassword2.Size = new System.Drawing.Size(123, 20);
            this.txtPassword2.TabIndex = 7;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AllowDrop = true;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.Location = new System.Drawing.Point(703, 55);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(112, 14);
            this.lblPassword2.TabIndex = 87;
            this.lblPassword2.Text = "Repita la contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(577, 27);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(252, 24);
            this.cboPerfil.TabIndex = 2;
            // 
            // lblEnrolar
            // 
            this.lblEnrolar.AllowDrop = true;
            this.lblEnrolar.AutoSize = true;
            this.lblEnrolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolar.Location = new System.Drawing.Point(574, 14);
            this.lblEnrolar.Name = "lblEnrolar";
            this.lblEnrolar.Size = new System.Drawing.Size(77, 13);
            this.lblEnrolar.TabIndex = 82;
            this.lblEnrolar.Text = "Enrolar usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(578, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(123, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(138, 31);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(48, 20);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AllowDrop = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(575, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 14);
            this.lblPassword.TabIndex = 80;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(456, 72);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(102, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(453, 55);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 77;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(312, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(135, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(192, 31);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(180, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AllowDrop = true;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(190, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.LblUsuario.AllowDrop = true;
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(135, 14);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(51, 13);
            this.LblUsuario.TabIndex = 84;
            this.LblUsuario.Text = "idUsuario";
            // 
            // chkChangePassword
            // 
            this.chkChangePassword.AutoSize = true;
            this.chkChangePassword.Location = new System.Drawing.Point(771, 395);
            this.chkChangePassword.Name = "chkChangePassword";
            this.chkChangePassword.Size = new System.Drawing.Size(113, 17);
            this.chkChangePassword.TabIndex = 88;
            this.chkChangePassword.Text = "Cambiar Password";
            this.chkChangePassword.UseVisualStyleBackColor = true;
            this.chkChangePassword.Visible = false;
            this.chkChangePassword.CheckedChanged += new System.EventHandler(this.chkChangePassword_CheckedChanged);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Width = 55;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 175;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 175;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 90;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 300;
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(378, 31);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(180, 20);
            this.txtApellidos.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Apellidos";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(907, 432);
            this.Controls.Add(this.chkChangePassword);
            this.Controls.Add(this.btnGroupUsuario);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.groupBoxUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.btnGroupUsuario.ResumeLayout(false);
            this.btnGroupUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStrip btnGroupUsuario;
        private System.Windows.Forms.ToolStripButton btnUsuarioNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUsuarioEditCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUsuarioDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox txtFiltro;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblEnrolar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.CheckBox chkChangePassword;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
    }
}