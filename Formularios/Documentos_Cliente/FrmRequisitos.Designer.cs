namespace Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente
{
    partial class FrmRequisitos
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDoci = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DcRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcOblig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcRef,
            this.DcDoc,
            this.DcOblig,
            this.DcEstado,
            this.DcRuta});
            this.DgvData.GridColor = System.Drawing.Color.AliceBlue;
            this.DgvData.Location = new System.Drawing.Point(72, 127);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(611, 223);
            this.DgvData.TabIndex = 11;
            this.DgvData.MultiSelectChanged += new System.EventHandler(this.DgvData_MultiSelectChanged);
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.DgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentDoubleClick);
            this.DgvData.SelectionChanged += new System.EventHandler(this.DgvData_SelectionChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(52, 38);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 21);
            this.LblNombre.TabIndex = 12;
            this.LblNombre.Text = "label1";
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // LblDoci
            // 
            this.LblDoci.AutoSize = true;
            this.LblDoci.Location = new System.Drawing.Point(538, 38);
            this.LblDoci.Name = "LblDoci";
            this.LblDoci.Size = new System.Drawing.Size(58, 21);
            this.LblDoci.TabIndex = 13;
            this.LblDoci.Text = "label1";
            this.LblDoci.Click += new System.EventHandler(this.LblDoci_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.Lime;
            this.BtnCargar.Location = new System.Drawing.Point(447, 91);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(112, 30);
            this.BtnCargar.TabIndex = 14;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Location = new System.Drawing.Point(565, 91);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 30);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pdf|*.pdf;*";
            // 
            // DcRef
            // 
            this.DcRef.HeaderText = "Codigo";
            this.DcRef.Name = "DcRef";
            this.DcRef.ReadOnly = true;
            // 
            // DcDoc
            // 
            this.DcDoc.HeaderText = "Documento";
            this.DcDoc.Name = "DcDoc";
            this.DcDoc.ReadOnly = true;
            this.DcDoc.Width = 110;
            // 
            // DcOblig
            // 
            this.DcOblig.HeaderText = "Obligatorio";
            this.DcOblig.Name = "DcOblig";
            this.DcOblig.ReadOnly = true;
            this.DcOblig.Width = 120;
            // 
            // DcEstado
            // 
            this.DcEstado.HeaderText = "Estado";
            this.DcEstado.Name = "DcEstado";
            this.DcEstado.ReadOnly = true;
            this.DcEstado.Visible = false;
            // 
            // DcRuta
            // 
            this.DcRuta.HeaderText = "Ruta";
            this.DcRuta.Name = "DcRuta";
            this.DcRuta.ReadOnly = true;
            this.DcRuta.Width = 200;
            // 
            // FrmRequisitos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(782, 382);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.LblDoci);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmRequisitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRequisitos";
            this.Load += new System.EventHandler(this.FrmRequisitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDoci;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcOblig;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRuta;
    }
}