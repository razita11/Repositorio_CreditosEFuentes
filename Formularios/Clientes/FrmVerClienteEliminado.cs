using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Creditos_EFuentes.Formularios.Clientes
{
    public partial class FrmVerClienteEliminado : Form
    {

        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();

        public FrmVerClienteEliminado()
        {
            InitializeComponent();
        }

        private void FrmVerClienteEliminado_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes(string dni = "")
        {
            DataTable clientes;
            string condicion = "ESTADO = 'INACTIVO'";

            if (!string.IsNullOrWhiteSpace(dni))
            {
                condicion += $" AND DNI LIKE '%{dni}%'";
            }

            string campos = "DNI, NOMBRE_RAZON, FECHA_N, CORREO, TIPO, DIRECCION, GENERO,TELEFONO, CELULAR, ESTADO, FOTO";
            clientes = db.Find("CLIENTES", campos, condicion);
            DgvData.Rows.Clear();

            foreach (DataRow infoclientes in clientes.Rows)
            {
                string _dni = infoclientes["DNI"].ToString();
                string _tipo = infoclientes["TIPO"].ToString();
                string _nombre = infoclientes["NOMBRE_RAZON"].ToString();
                string _direccion = infoclientes["DIRECCION"].ToString();
                string _telefono = infoclientes["TELEFONO"].ToString();
                string _celular = infoclientes["CELULAR"].ToString();
                string _genero = infoclientes["GENERO"].ToString();
                string _fecha = infoclientes["FECHA_N"].ToString();
                string _correo = infoclientes["CORREO"].ToString();
                string _foto = infoclientes["FOTO"].ToString();

                DgvData.Rows.Add(_dni, _nombre, _fecha, _correo, _direccion, _telefono, _genero, _celular, _foto, _tipo);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string dni = TxtBuscar.Text.Trim();
            ListarClientes(dni);
        }

        private void DgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvData.Rows.Count > 0)
            {
                string dni, nombre, fecha, correo, direccion, celular, telefono, tipo, genero,foto;
              
                dni = DgvData.CurrentRow.Cells[0].Value.ToString();
                nombre = DgvData.CurrentRow.Cells[1].Value.ToString();
                fecha = DgvData.CurrentRow.Cells[2].Value.ToString();
                correo = DgvData.CurrentRow.Cells[3].Value.ToString();
                direccion = DgvData.CurrentRow.Cells[4].Value.ToString();
                telefono = DgvData.CurrentRow.Cells[5].Value.ToString();
                genero = DgvData.CurrentRow.Cells[6].Value.ToString();
                celular = DgvData.CurrentRow.Cells[7].Value.ToString();
                foto = DgvData.CurrentRow.Cells[8].Value.ToString();

                tipo = DgvData.CurrentRow.Cells[9].Value.ToString();


                Formularios.Clientes.FrmEditarElimClientes Editar = new Formularios.Clientes.FrmEditarElimClientes();
                Editar = ((Formularios.Clientes.FrmEditarElimClientes)Owner);
                Editar.RecibirDatosClienteElim(dni, nombre, fecha, correo, direccion, celular, telefono, tipo, genero, foto);
                this.Close();
            }
        }

    }

    }
