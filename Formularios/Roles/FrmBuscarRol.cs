using Gestion_Creditos_EFuentes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Roles
{
    public partial class FrmBuscarRol : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmBuscarRol()
        {
            InitializeComponent();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string id = TxtBuscar.Text.Trim();
            ListarRoles(id);
        }

        private void ListarRoles(string id = "")
        {
            DataTable depto;
            string condicion = "ESTADO = 'A'";

            if (!string.IsNullOrWhiteSpace(id))
            {
                condicion += $" AND ID LIKE '%{id}%'";
            }

            string campos = "ID,ROL,ESTADO";
            depto = db.Find("ROLES", campos, condicion);
            DgvData.Rows.Clear();

            foreach (DataRow infodepto in depto.Rows)
            {
                string _id = infodepto["ID"].ToString();
                string _rol = infodepto["ROL"].ToString();
                string _estado = infodepto["ESTADO"].ToString();

                DgvData.Rows.Add(_id, _rol, _estado);
            }
        }
        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string id, rol, estado;
                id = DgvData.CurrentRow.Cells[0].Value.ToString();
                rol = DgvData.CurrentRow.Cells[1].Value.ToString();
                estado = DgvData.CurrentRow.Cells[2].Value.ToString();

                Formularios.Roles.FrmRoles Editar = new Formularios.Roles.FrmRoles();
                Editar = ((Formularios.Roles.FrmRoles)Owner);
                Editar.RecibirDatosRol(id, rol, estado);
                this.Close();
            }
        }

        private void FrmBuscarRol_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }
    }
}
