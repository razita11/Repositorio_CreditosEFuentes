namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    partial class FrmListarClientes
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(243, 27);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(279, 26);
            this.TxtBuscar.TabIndex = 6;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
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
            this.DcRegistro,
            this.DcDireccion,
            this.Foto,
            this.tipo,
            this.celular,
            this.DcEstado,
            this.telefono,
            this.genero});
            this.DgvData.Location = new System.Drawing.Point(19, 72);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(735, 285);
            this.DgvData.TabIndex = 4;
            this.DgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentDoubleClick);
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "DNI";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.ReadOnly = true;
            this.DcNombre.Width = 150;
            // 
            // Dc_Nombre
            // 
            this.Dc_Nombre.HeaderText = "Nombre";
            this.Dc_Nombre.Name = "Dc_Nombre";
            this.Dc_Nombre.ReadOnly = true;
            this.Dc_Nombre.Width = 200;
            // 
            // DcRol
            // 
            this.DcRol.HeaderText = "Fecha Nac";
            this.DcRol.Name = "DcRol";
            this.DcRol.ReadOnly = true;
            // 
            // DcRegistro
            // 
            this.DcRegistro.HeaderText = "Correo";
            this.DcRegistro.Name = "DcRegistro";
            this.DcRegistro.ReadOnly = true;
            this.DcRegistro.Width = 150;
            // 
            // DcDireccion
            // 
            this.DcDireccion.HeaderText = "Direccion ";
            this.DcDireccion.Name = "DcDireccion";
            this.DcDireccion.ReadOnly = true;
            this.DcDireccion.Visible = false;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // celular
            // 
            this.celular.HeaderText = "Column1";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Visible = false;
            // 
            // DcEstado
            // 
            this.DcEstado.HeaderText = "Estado";
            this.DcEstado.Name = "DcEstado";
            this.DcEstado.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Column1";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            // 
            // genero
            // 
            this.genero.HeaderText = "Column1";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Visible = false;
            // 
            // FrmListarClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListarClientes";
            this.Load += new System.EventHandler(this.FrmListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}