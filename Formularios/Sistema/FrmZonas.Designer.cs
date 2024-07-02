namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
    partial class FrmZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZonas));
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtnRegistrar = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelarOp = new System.Windows.Forms.ToolStripButton();
            this.CmbMunicipio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtZona = new System.Windows.Forms.TextBox();
            this.BtBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnverElim = new System.Windows.Forms.ToolStripButton();
            this.BtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.BtnReactivar = new System.Windows.Forms.ToolStripButton();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(270, 115);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(337, 29);
            this.CmbDepartamento.TabIndex = 40;
            this.CmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.CmbDepartamento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Departamento:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.BtnRegistrar,
            this.BtnCancelarOp,
            this.BtBuscar,
            this.BtnverElim,
            this.BtnActualizar,
            this.BtnEliminar,
            this.BtnReactivar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(71, 22);
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(87, 22);
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCancelarOp
            // 
            this.BtnCancelarOp.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarOp.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarOp.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarOp.Image")));
            this.BtnCancelarOp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelarOp.Name = "BtnCancelarOp";
            this.BtnCancelarOp.Size = new System.Drawing.Size(86, 22);
            this.BtnCancelarOp.Text = "Cancelar";
            this.BtnCancelarOp.Click += new System.EventHandler(this.BtnCancelarOp_Click);
            // 
            // CmbMunicipio
            // 
            this.CmbMunicipio.FormattingEnabled = true;
            this.CmbMunicipio.Location = new System.Drawing.Point(270, 166);
            this.CmbMunicipio.Name = "CmbMunicipio";
            this.CmbMunicipio.Size = new System.Drawing.Size(337, 29);
            this.CmbMunicipio.TabIndex = 42;
            this.CmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.CmbMunicipio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Zona:";
            // 
            // TxtZona
            // 
            this.TxtZona.Location = new System.Drawing.Point(270, 216);
            this.TxtZona.Name = "TxtZona";
            this.TxtZona.Size = new System.Drawing.Size(337, 26);
            this.TxtZona.TabIndex = 44;
            this.TxtZona.TextChanged += new System.EventHandler(this.TxtZona_TextChanged);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscar.ForeColor = System.Drawing.Color.White;
            this.BtBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtBuscar.Image")));
            this.BtBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(73, 22);
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtnverElim
            // 
            this.BtnverElim.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnverElim.ForeColor = System.Drawing.Color.White;
            this.BtnverElim.Image = ((System.Drawing.Image)(resources.GetObject("BtnverElim.Image")));
            this.BtnverElim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnverElim.Name = "BtnverElim";
            this.BtnverElim.Size = new System.Drawing.Size(104, 22);
            this.BtnverElim.Text = "BuscarElim";
            this.BtnverElim.Click += new System.EventHandler(this.BtnverElim_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 22);
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 22);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnReactivar
            // 
            this.BtnReactivar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReactivar.ForeColor = System.Drawing.Color.White;
            this.BtnReactivar.Image = ((System.Drawing.Image)(resources.GetObject("BtnReactivar.Image")));
            this.BtnReactivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReactivar.Name = "BtnReactivar";
            this.BtnReactivar.Size = new System.Drawing.Size(89, 22);
            this.BtnReactivar.Text = "Reactivar";
            this.BtnReactivar.Click += new System.EventHandler(this.BtnReactivar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(32, 55);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(41, 26);
            this.TxtCodigo.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 50);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Los Datos del Municipio";
            // 
            // FrmZonas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtZona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbMunicipio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmZonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmZonas";
            this.Load += new System.EventHandler(this.FrmZonas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.ToolStripButton BtnRegistrar;
        private System.Windows.Forms.ToolStripButton BtnCancelarOp;
        private System.Windows.Forms.ComboBox CmbMunicipio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtZona;
        private System.Windows.Forms.ToolStripButton BtBuscar;
        private System.Windows.Forms.ToolStripButton BtnverElim;
        private System.Windows.Forms.ToolStripButton BtnActualizar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripButton BtnReactivar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}