﻿using Gestion_Creditos_EFuentes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
    public partial class FrmBuscarDepto : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();   
        public FrmBuscarDepto()
        {
            InitializeComponent();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string id = TxtBuscar.Text.Trim();
            ListarDeptos(id);
        }

        private void ListarDeptos(string codigo = "")
        {
            DataTable depto;
            string condicion = "ESTADO = 'A'";

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                condicion += $" AND CODIGO LIKE '%{codigo}%'";
            }

            string campos = "CODIGO,DEPARTAMENTO,ESTADO";
            depto = db.Find("DEPARTAMENTOS", campos, condicion);
            DgvData.Rows.Clear();

            foreach (DataRow infodepto in depto.Rows)
            {
                string _codigo =infodepto["CODIGO"].ToString();
                string _depa = infodepto["DEPARTAMENTO"].ToString();
                string _estado = infodepto["ESTADO"].ToString();

                DgvData.Rows.Add(_codigo,_depa,_estado);
            }
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string codigo, municipio, estado;
                codigo = DgvData.CurrentRow.Cells[0].Value.ToString();
                municipio = DgvData.CurrentRow.Cells[1].Value.ToString();
                estado = DgvData.CurrentRow.Cells[2].Value.ToString();
 
                Formularios.Sistema.FrmDepartamentos Editar = new Formularios.Sistema.FrmDepartamentos();
                Editar = ((Formularios.Sistema.FrmDepartamentos)Owner);
                Editar.RecibirDatosDepto(codigo,municipio,estado);
                this.Close();
            }
        }

        private void FrmBuscarDepto_Load(object sender, EventArgs e)
        {
            ListarDeptos();
        }
    }
}