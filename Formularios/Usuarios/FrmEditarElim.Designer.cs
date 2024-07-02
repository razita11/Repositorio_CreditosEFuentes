namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    partial class FrmEditarElim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarElim));
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnActualizarUser = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarUser = new System.Windows.Forms.ToolStripButton();
            this.BtCancelarOP = new System.Windows.Forms.ToolStripButton();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnVerElim = new System.Windows.Forms.ToolStripButton();
            this.TxtBuscarUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.Dc_Nombre,
            this.DcRol,
            this.DcRegistro});
            this.DgvData.Location = new System.Drawing.Point(326, 84);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(435, 251);
            this.DgvData.TabIndex = 0;
            this.DgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentDoubleClick);
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "Usuario";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.ReadOnly = true;
            // 
            // Dc_Nombre
            // 
            this.Dc_Nombre.HeaderText = "Nombre";
            this.Dc_Nombre.Name = "Dc_Nombre";
            this.Dc_Nombre.ReadOnly = true;
            // 
            // DcRol
            // 
            this.DcRol.HeaderText = "Rol";
            this.DcRol.Name = "DcRol";
            this.DcRol.ReadOnly = true;
            // 
            // DcRegistro
            // 
            this.DcRegistro.HeaderText = "Registro";
            this.DcRegistro.Name = "DcRegistro";
            this.DcRegistro.ReadOnly = true;
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Location = new System.Drawing.Point(117, 322);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(203, 29);
            this.CmbRol.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rol:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(117, 180);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(203, 26);
            this.TxtCorreo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Correo:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(117, 134);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(203, 26);
            this.TxtNombre.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(117, 84);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(203, 26);
            this.TxtUsuario.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario:";
            // 
            // DtpFechaNac
            // 
            this.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNac.Location = new System.Drawing.Point(117, 229);
            this.DtpFechaNac.Name = "DtpFechaNac";
            this.DtpFechaNac.Size = new System.Drawing.Size(203, 26);
            this.DtpFechaNac.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fecha Nac:";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(117, 276);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(203, 26);
            this.TxtEstado.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Estado:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnActualizarUser,
            this.BtnEliminarUser,
            this.BtCancelarOP,
            this.BtnBuscar,
            this.BtnVerElim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 28);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnActualizarUser
            // 
            this.BtnActualizarUser.BackColor = System.Drawing.Color.Green;
            this.BtnActualizarUser.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarUser.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizarUser.Image")));
            this.BtnActualizarUser.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnActualizarUser.Name = "BtnActualizarUser";
            this.BtnActualizarUser.Size = new System.Drawing.Size(105, 25);
            this.BtnActualizarUser.Text = "Actualizar";
            this.BtnActualizarUser.Click += new System.EventHandler(this.BtnActualizarUser_Click);
            // 
            // BtnEliminarUser
            // 
            this.BtnEliminarUser.BackColor = System.Drawing.Color.Green;
            this.BtnEliminarUser.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUser.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarUser.Image")));
            this.BtnEliminarUser.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnEliminarUser.Name = "BtnEliminarUser";
            this.BtnEliminarUser.Size = new System.Drawing.Size(93, 25);
            this.BtnEliminarUser.Text = "Eliminar";
            this.BtnEliminarUser.Click += new System.EventHandler(this.BtnEliminarUser_Click);
            // 
            // BtCancelarOP
            // 
            this.BtCancelarOP.BackColor = System.Drawing.Color.Green;
            this.BtCancelarOP.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelarOP.ForeColor = System.Drawing.Color.White;
            this.BtCancelarOP.Image = ((System.Drawing.Image)(resources.GetObject("BtCancelarOP.Image")));
            this.BtCancelarOP.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtCancelarOP.Name = "BtCancelarOP";
            this.BtCancelarOP.Size = new System.Drawing.Size(96, 25);
            this.BtCancelarOP.Text = "Cancelar";
            this.BtCancelarOP.Click += new System.EventHandler(this.BtCancelarOP_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Green;
            this.BtnBuscar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 25);
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ToolTipText = "Eliminados";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnVerElim
            // 
            this.BtnVerElim.BackColor = System.Drawing.Color.Green;
            this.BtnVerElim.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerElim.ForeColor = System.Drawing.Color.White;
            this.BtnVerElim.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerElim.Image")));
            this.BtnVerElim.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnVerElim.Name = "BtnVerElim";
            this.BtnVerElim.Size = new System.Drawing.Size(113, 25);
            this.BtnVerElim.Text = "Eliminados";
            this.BtnVerElim.ToolTipText = "Eliminados";
            this.BtnVerElim.Click += new System.EventHandler(this.BtnVerElim_Click);
            // 
            // TxtBuscarUser
            // 
            this.TxtBuscarUser.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarUser.Location = new System.Drawing.Point(486, 52);
            this.TxtBuscarUser.Name = "TxtBuscarUser";
            this.TxtBuscarUser.Size = new System.Drawing.Size(248, 26);
            this.TxtBuscarUser.TabIndex = 35;
            this.TxtBuscarUser.TextChanged += new System.EventHandler(this.TxtBuscarUser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Buscar Usuario:";
            // 
            // FrmEditarElim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBuscarUser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtpFechaNac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarElim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarElim";
            this.Load += new System.EventHandler(this.FrmEditarElim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaNac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRegistro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnActualizarUser;
        private System.Windows.Forms.ToolStripButton BtnEliminarUser;
        private System.Windows.Forms.ToolStripButton BtnVerElim;
        private System.Windows.Forms.ToolStripButton BtCancelarOP;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscarUser;
        private System.Windows.Forms.Label label2;
    }
}