namespace Gestion_Creditos_EFuentes.Formularios.Avales
{
    partial class FrmVerElim
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
            this.DcApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(239, 27);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(279, 26);
            this.TxtBuscar.TabIndex = 9;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 8;
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
            this.DcApellidos,
            this.DcDireccion,
            this.DcTelefono,
            this.DcGenero,
            this.DcFecha,
            this.DcCorreo});
            this.DgvData.GridColor = System.Drawing.Color.AliceBlue;
            this.DgvData.Location = new System.Drawing.Point(15, 72);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(742, 285);
            this.DgvData.TabIndex = 7;
            this.DgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentDoubleClick);
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "DNI";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.ReadOnly = true;
            this.DcNombre.Width = 200;
            // 
            // Dc_Nombre
            // 
            this.Dc_Nombre.HeaderText = "Nombre";
            this.Dc_Nombre.Name = "Dc_Nombre";
            this.Dc_Nombre.ReadOnly = true;
            this.Dc_Nombre.Width = 200;
            // 
            // DcApellidos
            // 
            this.DcApellidos.HeaderText = "Apellido";
            this.DcApellidos.Name = "DcApellidos";
            this.DcApellidos.ReadOnly = true;
            this.DcApellidos.Width = 200;
            // 
            // DcDireccion
            // 
            this.DcDireccion.HeaderText = "Direccion";
            this.DcDireccion.Name = "DcDireccion";
            this.DcDireccion.ReadOnly = true;
            this.DcDireccion.Visible = false;
            // 
            // DcTelefono
            // 
            this.DcTelefono.HeaderText = "Telefono";
            this.DcTelefono.Name = "DcTelefono";
            this.DcTelefono.ReadOnly = true;
            this.DcTelefono.Visible = false;
            // 
            // DcGenero
            // 
            this.DcGenero.HeaderText = "Genero";
            this.DcGenero.Name = "DcGenero";
            this.DcGenero.ReadOnly = true;
            this.DcGenero.Visible = false;
            // 
            // DcFecha
            // 
            this.DcFecha.HeaderText = "Fecha Nacimient";
            this.DcFecha.Name = "DcFecha";
            this.DcFecha.ReadOnly = true;
            // 
            // DcCorreo
            // 
            this.DcCorreo.HeaderText = "Correo";
            this.DcCorreo.Name = "DcCorreo";
            this.DcCorreo.ReadOnly = true;
            this.DcCorreo.Visible = false;
            // 
            // FrmVerElim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmVerElim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerElim";
            this.Load += new System.EventHandler(this.FrmVerElim_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DcApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCorreo;
    }
}