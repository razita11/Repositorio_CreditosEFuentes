namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    partial class FrmEditarElimClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarElimClientes));
            this.BtnLogo = new System.Windows.Forms.Button();
            this.ImgCli = new System.Windows.Forms.PictureBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnActualizarUser = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarUser = new System.Windows.Forms.ToolStripButton();
            this.BtCancelarOP = new System.Windows.Forms.ToolStripButton();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnVerElim = new System.Windows.Forms.ToolStripButton();
            this.BtnReacitvar = new System.Windows.Forms.ToolStripButton();
            this.BtnRequisitos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCli)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogo
            // 
            this.BtnLogo.Location = new System.Drawing.Point(471, 341);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(254, 33);
            this.BtnLogo.TabIndex = 63;
            this.BtnLogo.Text = "Agregar Fotografía";
            this.BtnLogo.UseVisualStyleBackColor = true;
            this.BtnLogo.Click += new System.EventHandler(this.BtnLogo_Click);
            // 
            // ImgCli
            // 
            this.ImgCli.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ImgCli.Location = new System.Drawing.Point(502, 173);
            this.ImgCli.Name = "ImgCli";
            this.ImgCli.Size = new System.Drawing.Size(207, 162);
            this.ImgCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCli.TabIndex = 62;
            this.ImgCli.TabStop = false;
            this.ImgCli.Click += new System.EventHandler(this.ImgCli_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(129, 234);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(269, 26);
            this.TxtTelefono.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Telefono:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(129, 186);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(269, 26);
            this.TxtCelular.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 58;
            this.label8.Text = "Celular:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(129, 139);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(596, 26);
            this.TxtDireccion.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Dirección:";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Identidad",
            "RTN",
            "Pasaporte",
            "Carnet de Residente ",
            "Carnet de Ciudadano",
            "Licencia"});
            this.CmbTipo.Location = new System.Drawing.Point(529, 35);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(196, 29);
            this.CmbTipo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(451, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tipo:";
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.CmbGenero.Location = new System.Drawing.Point(129, 324);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(269, 29);
            this.CmbGenero.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Genero:";
            // 
            // DtpFechaNac
            // 
            this.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNac.Location = new System.Drawing.Point(129, 278);
            this.DtpFechaNac.Name = "DtpFechaNac";
            this.DtpFechaNac.Size = new System.Drawing.Size(269, 26);
            this.DtpFechaNac.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Fecha Nac:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(529, 85);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(196, 26);
            this.TxtCorreo.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(451, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Correo:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(129, 85);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(269, 26);
            this.TxtNombre.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre:";
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(129, 38);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(269, 26);
            this.TxtDni.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dni:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnActualizarUser,
            this.BtnEliminarUser,
            this.BtCancelarOP,
            this.BtnBuscar,
            this.BtnVerElim,
            this.BtnReacitvar,
            this.BtnRequisitos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 28);
            this.toolStrip1.TabIndex = 64;
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
            // BtnReacitvar
            // 
            this.BtnReacitvar.BackColor = System.Drawing.Color.Green;
            this.BtnReacitvar.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReacitvar.ForeColor = System.Drawing.Color.White;
            this.BtnReacitvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnReacitvar.Image")));
            this.BtnReacitvar.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnReacitvar.Name = "BtnReacitvar";
            this.BtnReacitvar.Size = new System.Drawing.Size(82, 25);
            this.BtnReacitvar.Text = "Activar";
            this.BtnReacitvar.ToolTipText = "Activar";
            this.BtnReacitvar.Click += new System.EventHandler(this.BtnReacitvar_Click);
            // 
            // BtnRequisitos
            // 
            this.BtnRequisitos.BackColor = System.Drawing.Color.Green;
            this.BtnRequisitos.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequisitos.ForeColor = System.Drawing.Color.White;
            this.BtnRequisitos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRequisitos.Image")));
            this.BtnRequisitos.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnRequisitos.Name = "BtnRequisitos";
            this.BtnRequisitos.Size = new System.Drawing.Size(107, 25);
            this.BtnRequisitos.Text = "Requisitos";
            this.BtnRequisitos.ToolTipText = "Activar";
            this.BtnRequisitos.Click += new System.EventHandler(this.BtnRequisitos_Click);
            // 
            // FrmEditarElimClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnLogo);
            this.Controls.Add(this.ImgCli);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtpFechaNac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmEditarElimClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarElimClientes";
            this.Load += new System.EventHandler(this.FrmEditarElimClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCli)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogo;
        private System.Windows.Forms.PictureBox ImgCli;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFechaNac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnActualizarUser;
        private System.Windows.Forms.ToolStripButton BtnEliminarUser;
        private System.Windows.Forms.ToolStripButton BtCancelarOP;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.ToolStripButton BtnVerElim;
        private System.Windows.Forms.ToolStripButton BtnReacitvar;
        private System.Windows.Forms.ToolStripButton BtnRequisitos;
    }
}