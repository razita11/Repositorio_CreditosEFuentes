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
    public partial class FrmBuscarZona : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmBuscarZona()
        {
            InitializeComponent();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string id = TxtBuscar.Text.Trim();
            ListarZonas(id);
        }
        private void ListarZonas(string codigo = "")
        {
            DataTable zonas;
            string condicion = "ZONAS.ESTADO = 'A'";

            if (!string.IsNullOrWhiteSpace(codigo))
            {
                condicion += $" AND ZONAS.CODIGO LIKE '%{codigo}%'";
            }

            string campos = "ZONAS.CODIGO, ZONAS.ZONA, DEPARTAMENTOS.DEPARTAMENTO, MUNICIPIOS.MUNICIPIO, ZONAS.ESTADO";
            string joins = "INNER JOIN MUNICIPIOS ON ZONAS.COD_MUNI = MUNICIPIOS.CODIGO " +
                           "INNER JOIN DEPARTAMENTOS ON MUNICIPIOS.COD_DEPTO = DEPARTAMENTOS.CODIGO";
            zonas = db.FindInner("ZONAS", campos, condicion, joins);
            DgvData.Rows.Clear();

            foreach (DataRow infoZona in zonas.Rows)
            {
                string _codigo = infoZona["CODIGO"].ToString();
                string _zona = infoZona["ZONA"].ToString();
                string _departamento = infoZona["DEPARTAMENTO"].ToString();
                string _municipio = infoZona["MUNICIPIO"].ToString();
                string _estado = infoZona["ESTADO"].ToString();

                DgvData.Rows.Add(_codigo, _zona, _departamento, _municipio, _estado);
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBuscarZona_Load(object sender, EventArgs e)
        {
            ListarZonas();
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string codigo, zona, estado, departamento, municipio;
                codigo = DgvData.CurrentRow.Cells[0].Value.ToString();
                zona = DgvData.CurrentRow.Cells[1].Value.ToString();
                departamento = DgvData.CurrentRow.Cells[2].Value.ToString();
                municipio = DgvData.CurrentRow.Cells[3].Value.ToString();
                estado = DgvData.CurrentRow.Cells[4].Value.ToString();
                Formularios.Sistema.FrmZonas Editar = (Formularios.Sistema.FrmZonas)Owner;
                Editar.RecibirDatosZona(codigo, zona, estado, departamento, municipio);
                this.Close();
            }
        }
    }
}
