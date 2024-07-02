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
    public partial class FrmBuscarMuni : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmBuscarMuni()
        {
            InitializeComponent();
        }

        private void FrmBuscarMuni_Load(object sender, EventArgs e)
        {
            ListarMuni();
        }
        private void ListarMuni(string codigo = "")
        {
            DataTable municipios;
            string condicion = "MUNICIPIOS.ESTADO = 'A'";

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                condicion += $" AND MUNICIPIOS.CODIGO LIKE '%{codigo}%'";
            }

            string campos = "MUNICIPIOS.CODIGO, MUNICIPIOS.MUNICIPIO, DEPARTAMENTOS.DEPARTAMENTO, MUNICIPIOS.ESTADO";
            string joins = "INNER JOIN DEPARTAMENTOS ON MUNICIPIOS.COD_DEPTO = DEPARTAMENTOS.CODIGO";
            municipios = db.FindInner("MUNICIPIOS", campos, condicion, joins);
            DgvData.Rows.Clear();

            foreach (DataRow infoMuni in municipios.Rows)
            {
                string _codigo = infoMuni["CODIGO"].ToString();
                string _municipio = infoMuni["MUNICIPIO"].ToString();
                string _departamento = infoMuni["DEPARTAMENTO"].ToString();
                string _estado = infoMuni["ESTADO"].ToString();

                DgvData.Rows.Add(_codigo, _municipio, _departamento, _estado);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string id = TxtBuscar.Text.Trim();
            ListarMuni(id);
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string codigo, municipio, estado, departamento;
                codigo = DgvData.CurrentRow.Cells[0].Value.ToString();
                municipio = DgvData.CurrentRow.Cells[1].Value.ToString();
                departamento = DgvData.CurrentRow.Cells[2].Value.ToString();
                estado = DgvData.CurrentRow.Cells[3].Value.ToString();

                Formularios.Sistema.FrmMunicipio Editar = (Formularios.Sistema.FrmMunicipio)Owner;
                Editar.RecibirDatosMuni(codigo, municipio, estado, departamento);
                this.Close();
            }
        }
    }
}
