using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Documentos_Cliente
{
    public partial class FrmBuscarRequisito : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        public FrmBuscarRequisito()
        {
            InitializeComponent();
        }


        private void listarDocs(string codigo = " ")
        {
            DataTable documentos;
            string condicion = "ESTADO = 'A'";

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                condicion += $" AND CODIGO LIKE '%{codigo}%'";
            }

            string campos = "CODIGO,DOCUMENTO,OBLIG,ESTADO";
            documentos = db.Find("REQUISITOS", campos, condicion);
            DgvData.Rows.Clear();

            foreach (DataRow infodocu in documentos.Rows)
            {
                string _codigo = infodocu["CODIGO"].ToString();
                string _doc = infodocu["DOCUMENTO"].ToString();
                string _oblig = infodocu["OBLIG"].ToString();
                string _estado = infodocu["ESTADO"].ToString();

                DgvData.Rows.Add(_codigo, _doc,_oblig, _estado);
            }

        }


        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string id = TxtBuscar.Text.Trim();
            listarDocs(id);
        }

        private void FrmBuscarRequisito_Load(object sender, EventArgs e)
        {
            listarDocs();
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string codigo, documento,oblig, estado;
                codigo = DgvData.CurrentRow.Cells[0].Value.ToString();
                documento = DgvData.CurrentRow.Cells[1].Value.ToString();
                oblig = DgvData.CurrentRow.Cells[2].Value.ToString();
                estado = DgvData.CurrentRow.Cells[3].Value.ToString();


                Formularios.Documentos_Cliente.FrmRegistrarRequisitos Editar = new Formularios.Documentos_Cliente.FrmRegistrarRequisitos();
                Editar = ((Formularios.Documentos_Cliente.FrmRegistrarRequisitos)Owner);
                Editar.RecibirDatosDoc(codigo, documento,oblig,estado);
                this.Close();
            }
        }
    }
}
