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

namespace Gestion_Creditos_EFuentes.Formularios.Avales
{
    public partial class FrmVerElim : Form
    {
        Clases.Auth auth = new Clases.Auth();
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        public FrmVerElim()
        {
            InitializeComponent();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string dni = TxtBuscar.Text.Trim();
            ListarAvales(dni);
        }
        private void ListarAvales(string dni = "")
        {
            DataTable avales;

            string condicion = "ESTADO = 'I'";

            if (!string.IsNullOrWhiteSpace(dni))
            {
                condicion += $" AND DNI LIKE '%{dni}%'";
            }

            string campos = "DNI,NOMBRE,APELLIDOS,DIRECCION,TELEFONO,GENERO,FECHA_N,CORREO";

            avales = db.Find("AVALES", campos, condicion);

            DgvData.Rows.Clear();

            foreach (DataRow aval in avales.Rows)
            {
                string _dni = aval["DNI"].ToString();
                string _nombre = aval["NOMBRE"].ToString();
                string _apellidos = aval["APELLIDOS"].ToString();
                string _direccion = aval["DIRECCION"].ToString();
                string _telefono = aval["TELEFONO"].ToString();
                string _genero = aval["GENERO"].ToString();
                string _fecha_N = aval["FECHA_N"].ToString();
                string _correo = aval["CORREO"].ToString();

                DgvData.Rows.Add(_dni, _nombre, _apellidos, _direccion, _telefono, _genero, _fecha_N, _correo);

                avales.Dispose();
            }

        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvData.Rows.Count > 0)
            {
                string dni, nombre, apellidos, direccion, telefono, genero, fecha_n, correo;

                dni = DgvData.CurrentRow.Cells[0].Value.ToString();
                nombre = DgvData.CurrentRow.Cells[1].Value.ToString();
                apellidos = DgvData.CurrentRow.Cells[2].Value.ToString();
                direccion = DgvData.CurrentRow.Cells[3].Value.ToString();
                telefono = DgvData.CurrentRow.Cells[4].Value.ToString();
                genero = DgvData.CurrentRow.Cells[5].Value.ToString();
                fecha_n = DgvData.CurrentRow.Cells[6].Value.ToString();
                correo = DgvData.CurrentRow.Cells[7].Value.ToString();

                Formularios.Avales.FrmEditElimAvales editar = new FrmEditElimAvales();
                editar = ((Formularios.Avales.FrmEditElimAvales)Owner);
                editar.RecibirDatosElimAvales(dni, nombre, apellidos, direccion, telefono, genero, fecha_n, correo);
                this.Close();

            }

        }

        private void FrmVerElim_Load(object sender, EventArgs e)
        {
            ListarAvales();
        }
    }
}
