﻿namespace Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente
{
    partial class FrmBuscarElimRequi
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
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcObligatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(245, 24);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(221, 26);
            this.TxtBuscar.TabIndex = 12;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar:";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCodigo,
            this.DcNombre,
            this.DcObligatorio,
            this.DcEstado});
            this.DgvData.GridColor = System.Drawing.Color.AliceBlue;
            this.DgvData.Location = new System.Drawing.Point(68, 71);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(611, 182);
            this.DgvData.TabIndex = 10;
            this.DgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentDoubleClick);
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "Codigo";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.ReadOnly = true;
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "Nombre";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.ReadOnly = true;
            this.DcNombre.Width = 250;
            // 
            // DcObligatorio
            // 
            this.DcObligatorio.HeaderText = "Obligatorio";
            this.DcObligatorio.Name = "DcObligatorio";
            this.DcObligatorio.ReadOnly = true;
            this.DcObligatorio.Width = 120;
            // 
            // DcEstado
            // 
            this.DcEstado.HeaderText = "Estado";
            this.DcEstado.Name = "DcEstado";
            this.DcEstado.ReadOnly = true;
            // 
            // FrmBuscarElimRequi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(747, 277);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmBuscarElimRequi";
            this.Text = "FrmBuscarElimRequi";
            this.Load += new System.EventHandler(this.FrmBuscarElimRequi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcObligatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEstado;
    }
}