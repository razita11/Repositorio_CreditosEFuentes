using Gestion_Creditos_EFuentes.Formularios.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Gestion_Creditos_EFuentes.Formularios.Sistema
{
    public partial class FrmDepartamentos : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers ();

        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string departamento;

            departamento = TxtDepartamento.Text.Trim();

            string campos = "DEPARTAMENTO";
            string valores = $"'{departamento}'";

            if (db.Save("DEPARTAMENTOS", campos, valores)) 
            {
                h.Success("El departamento se registro con Exito");
                Nuevo();
            }
            else
            {
                h.advertencia("Error al registrar el Departamento");
            }


        }

        private void ClearnForm()
        {
            TxtDepartamento.Clear();
            TxtCodigo.Clear();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnCancelarOp.Enabled = true;
            BtnRegistrar.Enabled = true;
            BtnNuevo.Enabled = false;
            TxtDepartamento.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = false;
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            Nuevo();

        }

        public void RecibirDatosDepto(string codigo, string departamento, string estado)
        {
            TxtDepartamento.Enabled = true;
            TxtDepartamento.Text = departamento;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnReactivar.Enabled = false;
            TxtCodigo.Text = codigo;
        }

        public void RecibirDatosElimDepto(string codigo, string departamento, string estado)
        {
            TxtDepartamento.Enabled = true;
            TxtDepartamento.Text = departamento;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = true;
            TxtCodigo.Text = codigo;
        }

        private void Nuevo()
        {
            BtnNuevo.Enabled = true;
            BtnCancelarOp.Enabled = false;
            BtnRegistrar.Enabled = false;
            TxtDepartamento.Clear();
            TxtDepartamento.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim();
            string departamento = TxtDepartamento.Text.Trim();
            string actualizar = $"DEPARTAMENTO='{departamento}'";
            string condicion = $"CODIGO='{codigo}'";

            if (db.update("DEPARTAMENTOS", actualizar, condicion)>0)
            {
                h.Success("Los Datos Se actualizaron con Exito");
                TxtDepartamento.Clear();
                TxtCodigo.Clear();
            }
            else
            {
                h.advertencia("Error al Actualizar al Departamento");
            }
            BtnReactivar.Enabled = true;
        }

        private void BtnReactivar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Departamento como Activo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='A'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("DEPARTAMENTOS", actualizar, condicion) > 0)
                {
                    h.Success("El Departamento se ha marcado como Activo con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Departamento.");
                }
            }
        }

        private void DeshabilitarBotones()
        {
            BtnEliminar.Enabled = false;
            BtnReactivar.Enabled = false;
            BtnActualizar.Enabled = false;
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmBuscarDepto buscar = new FrmBuscarDepto();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea marcar este Departamento como Inactivo?";

            if (h.Question(msg) == true)
            {
                string codigo = TxtCodigo.Text.Trim();
                string actualizar = $"ESTADO='I'";
                string condicion = $"CODIGO='{codigo}'";

                if (db.update("DEPARTAMENTOS", actualizar, condicion) > 0)
                {
                    h.Success("El Departamenton se ha marcado como INACTIVO con Éxito");
                    ClearnForm();
                }
                else
                {
                    h.advertencia("Error al actualizar el estado del Departamento.");
                }
            }
        }

        private void BtnverElim_Click(object sender, EventArgs e)
        {
            Formularios.Sistema.FrmVerDeptoelim buscar = new FrmVerDeptoelim();
            this.AddOwnedForm(buscar);
            ClearnForm();
            buscar.Show();
        }
    }
}
