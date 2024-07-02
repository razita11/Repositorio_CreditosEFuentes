namespace Gestion_Creditos_EFuentes.Formularios.Usuarios
{
    partial class FrmListarUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarUsers));
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnReportes = new System.Windows.Forms.ToolStripButton();
            this.BtnMora = new System.Windows.Forms.ToolStripButton();
            this.BtnCreditos = new System.Windows.Forms.ToolStripButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblBuscar = new System.Windows.Forms.Label();
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
            this.DcRegistro,
            this.Estadp,
            this.Correo});
            this.DgvData.Location = new System.Drawing.Point(29, 103);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(719, 251);
            this.DgvData.TabIndex = 45;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnReportes,
            this.BtnCreditos,
            this.BtnMora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 28);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.Green;
            this.BtnReportes.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportes.Image")));
            this.BtnReportes.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(90, 25);
            this.BtnReportes.Text = "Reporte";
            // 
            // BtnMora
            // 
            this.BtnMora.BackColor = System.Drawing.Color.Green;
            this.BtnMora.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMora.ForeColor = System.Drawing.Color.White;
            this.BtnMora.Image = ((System.Drawing.Image)(resources.GetObject("BtnMora.Image")));
            this.BtnMora.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnMora.Name = "BtnMora";
            this.BtnMora.Size = new System.Drawing.Size(68, 25);
            this.BtnMora.Text = "Mora";
            this.BtnMora.ToolTipText = "Eliminados";
            // 
            // BtnCreditos
            // 
            this.BtnCreditos.BackColor = System.Drawing.Color.Green;
            this.BtnCreditos.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreditos.ForeColor = System.Drawing.Color.White;
            this.BtnCreditos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreditos.Image")));
            this.BtnCreditos.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.BtnCreditos.Name = "BtnCreditos";
            this.BtnCreditos.Size = new System.Drawing.Size(92, 25);
            this.BtnCreditos.Text = "Creditos";
            this.BtnCreditos.ToolTipText = "Eliminados";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(303, 62);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(249, 26);
            this.TxtBuscar.TabIndex = 47;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
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
            this.Dc_Nombre.Width = 150;
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
            // Estadp
            // 
            this.Estadp.HeaderText = "Estado";
            this.Estadp.Name = "Estadp";
            this.Estadp.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(224, 65);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(73, 21);
            this.LblBuscar.TabIndex = 48;
            this.LblBuscar.Text = "Buscar:";
            // 
            // FrmListarUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 384);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmListarUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListarUsers";
            this.Load += new System.EventHandler(this.FrmListarUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnReportes;
        private System.Windows.Forms.ToolStripButton BtnCreditos;
        private System.Windows.Forms.ToolStripButton BtnMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
    }
}